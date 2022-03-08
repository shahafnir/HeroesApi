using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using HeroesApi.Services.Heroes;
using HeroesApi.Dtos.Requests;

namespace HeroesApi.Filters
{
    public class SameHeroNameExistsFilter : IAsyncActionFilter
    {
        private readonly IHeroesService _heroesService;

        public SameHeroNameExistsFilter(IHeroesService heroesService)
        {
            _heroesService = heroesService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var hero = (SaveHeroDto)context.ActionArguments["hero"];

            var nameExist = await _heroesService.HeroNameExist(hero.Name);

            if (nameExist)
            {
                context.ModelState.AddModelError("NameExist", "Hero name already in use");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
            else
                await next();
        }
    }
}
