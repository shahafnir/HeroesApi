using Microsoft.AspNetCore.Identity;
using HeroesApi.Models.IdentityModels;
using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;
using System.Security.Claims;

namespace HeroesApi.Services.Users
{
    public interface IUsersService
    {
        Task<AuthResultDto> Register(UserRegistrationDto user);
        Task<AuthResultDto> Login(UserLoginRequestDto user);
        Task<UserDetailsDto> GetUserDetails(ClaimsPrincipal userClaims);
        string GetUserId(ClaimsPrincipal userClaims);
    }
}
