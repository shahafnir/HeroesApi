using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;
using HeroesApi.Services.Users;

namespace HeroesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("User")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<UserDetailsDto>> GetUserDetails()
        {
            var userDetails = await _usersService.GetUserDetails(User);

            return Ok(userDetails);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<AuthResultDto>> Register([FromBody] UserRegistrationDto user)
        {
            var authResult = await _usersService.Register(user);

            if (!authResult.Success)
                return BadRequest(authResult);

            return Ok(authResult);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<AuthResultDto>> Login([FromBody] UserLoginRequestDto user)
        {
            var authResult = await _usersService.Login(user);

            if (!authResult.Success)
                return BadRequest(authResult);

            return Ok(authResult);
        }
    }
}
