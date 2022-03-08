using Microsoft.AspNetCore.Mvc;
using HeroesApi.Services.Heroes;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HeroesApi.Filters
{
    public class HeroValidForRemovalFilter : IAsyncActionFilter
    {
        private readonly IHeroesService _heroesService;

        public HeroValidForRemovalFilter(IHeroesService heroesService)
        {
            _heroesService = heroesService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var heroId = (string)context.ActionArguments["heroId"];
            var heroInDb = await _heroesService.GetHeroById(heroId);
            var userId = context.HttpContext.User.Claims.FirstOrDefault().Value;

            if (heroInDb == null || heroInDb.ApplicationUserId.ToString() != userId)
                context.Result = new BadRequestObjectResult(new { error = "Invalid hero ID" });
            else await next();
        }
    }
}
