using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;
using HeroesApi.Models.Heroes;

namespace HeroesApi.Services.Heroes
{
    public interface IHeroesService
    {
        Task<HeroDetailsDto> CreateHero(SaveHeroDto hero, string userId);
        Task<bool> HeroNameExist(string name);
        Task<Hero> GetHeroById(string heroId);
        Task<IEnumerable<HeroDetailsDto>> GetAllHeroesDetailsDtos();
        Task<HeroTrainingResultDto> TrainHero(string userId, string heroId);
        Task RemoveHero(string heroId);
    }
}
