using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;
using HeroesApi.Services.Heroes;
using HeroesApi.Services.Users;
using HeroesApi.Filters;

namespace HeroesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class HeroesController : ControllerBase
    {
        private readonly IHeroesService _heroesService;
        private readonly IUsersService _usersService;

        public HeroesController(
            IHeroesService heroesService,
            IUsersService usersService)
        {
            _heroesService = heroesService;
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroDetailsDto>>> GetAllHeroes()
        {
            var heroesDtos = await _heroesService.GetAllHeroesDetailsDtos();

            return Ok(heroesDtos);
        }

        [HttpPost]
        [TypeFilter(typeof(SameHeroNameExistsFilter))]
        public async Task<ActionResult<HeroDetailsDto>> CreateHero([FromBody] SaveHeroDto hero)
        {
            var userId = _usersService.GetUserId(User);
            var newHero = await _heroesService.CreateHero(hero, userId);

            return StatusCode(StatusCodes.Status201Created, newHero);
        }

        [HttpPatch("{heroId}/HeroTrainings")]
        public async Task<ActionResult<HeroTrainingResultDto>> HeroTrainings([FromRoute] string heroId)
        {
            var userId = _usersService.GetUserId(User);
            var heroTrainingResult = await _heroesService.TrainHero(userId, heroId);

            return Ok(heroTrainingResult);
        }

        [HttpDelete("{heroId}")]
        [TypeFilter(typeof(HeroValidForRemovalFilter))]
        public async Task<IActionResult> DeleteHero([FromRoute] string heroId)
        {
            await _heroesService.RemoveHero(heroId);

            return Ok();
        }
    }
}
