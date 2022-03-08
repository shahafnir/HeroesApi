using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HeroesApi.Data;
using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;
using HeroesApi.Models.Heroes;
using HeroesApi.Utilities;

namespace HeroesApi.Services.Heroes
{
    public class HeroesService : IHeroesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HeroesService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<HeroDetailsDto> CreateHero(SaveHeroDto hero, string userId)
        {
            var newHero = _mapper.Map<SaveHeroDto, Hero>(hero);

            newHero.Id = Guid.NewGuid();
            newHero.ApplicationUserId = userId;
            newHero.StartingPower = Utils.GetRandomNumberInRange(30, 50);
            newHero.CurrentPower = newHero.StartingPower;

            await _context.AddAsync(newHero);
            await SaveChanges();

            return _mapper.Map<Hero, HeroDetailsDto>(newHero);
        }

        public async Task<bool> HeroNameExist(string name)
        {
            return await _context.Heroes.AnyAsync(h => h.Name == name);
        }

        public async Task<Hero> GetHeroById(string heroId)
        {
            return await _context.Heroes
                 .Include(h => h.SuitColors)
                 .FirstOrDefaultAsync(hero => hero.Id.ToString() == heroId);
        }

        public async Task<IEnumerable<HeroDetailsDto>> GetAllHeroesDetailsDtos()
        {
            var heroes = await GetAllHeroes();

            return _mapper.Map<List<HeroDetailsDto>>(heroes);
        }

        public async Task<HeroTrainingResultDto> TrainHero(string userId, string heroId)
        {
            var heroInDb = await _context.Heroes.FirstOrDefaultAsync(h => h.Id.ToString() == heroId);

            if (heroInDb == null)
                return new HeroTrainingResultDto()
                {
                    Success = false,
                    Error = $"Hero ID: {heroId} not found"
                };

            if (heroInDb.ApplicationUserId.ToString() != userId)
                return new HeroTrainingResultDto()
                {
                    Success = false,
                    Error = $"Current user is not allowed to train Hero ID: {heroId}"
                };

            var trainingsTodayCount = await GetTrainingsTodayCountByHeroId(heroId);

            if (trainingsTodayCount >= 5)
                return new HeroTrainingResultDto()
                {
                    Success = false,
                    Error = $"Cannot train Hero: {heroInDb.Name} more than 5 times a day"
                };

            var powerIncrementPercent = Utils.GetRandomNumberInRange(0, 10);
            heroInDb.Train(powerIncrementPercent);
            await AddHeroTraining(heroId);

            return new HeroTrainingResultDto()
            {
                Success = true,
                PowerIncrementPercent = powerIncrementPercent,
                CurrentPower = heroInDb.CurrentPower,
            };
        }

        public async Task RemoveHero(string heroId)
        {
            var hero = await GetHeroById(heroId);
            _context.Heroes.Remove(hero);
            await SaveChanges();
        }

        private async Task<IEnumerable<Hero>> GetAllHeroes()
        {
            return await _context.Heroes
                .Include(h => h.SuitColors)
                .ToListAsync();
        }

        private async Task AddHeroTraining(string heroId)
        {
            var heroTraining = HeroTraining.Create(heroId);

            await _context.AddAsync(heroTraining);
            await SaveChanges();
        }

        private async Task<int> GetTrainingsTodayCountByHeroId(string heroId)
        {
            var todaysDate = DateTime.UtcNow;

            return await _context.HeroTrainings
                .Where(ht => ht.HeroId.ToString() == heroId
                    && ht.TrainedAt.Date == todaysDate.Date)
                .CountAsync();
        }

        private async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
