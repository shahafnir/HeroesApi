using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using HeroesApi.Models.IdentityModels;
using HeroesApi.Configurations;
using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;

namespace HeroesApi.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly IMapper _mapper;

        public UsersService(UserManager<ApplicationUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor,
            IMapper mapper)
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            _mapper = mapper;
        }

        public async Task<AuthResultDto> Register(UserRegistrationDto user)
        {
            var existingUser = await GetUserByEmail(user.Email);

            if (existingUser != null)
                return new AuthResultDto()
                {
                    Errors = new List<string>()
                    {
                        "Email already in use"
                    },
                    Success = false
                };

            var newUser = ConvertFromRegistrationDtoToUser(user);

            var isCreated = await _userManager.CreateAsync(newUser, user.Password);

            if (!isCreated.Succeeded)
                return new AuthResultDto()
                {
                    Errors = isCreated.Errors.Select(err => err.Description).ToList(),
                    Success = false
                };

            var jwtToken = GenerateJwtToken(newUser);

            return new AuthResultDto()
            {
                Success = true,
                Token = jwtToken,
                TrainerId = newUser.Id
            };
        }

        public async Task<AuthResultDto> Login(UserLoginRequestDto user)
        {
            var existingUser = await GetUserByEmail(user.Email);

            if (existingUser == null)
                return new AuthResultDto()
                {
                    Errors = new List<string>()
                    {
                        "Invalid login request"
                    },
                    Success = false
                };

            var isCorrect = await CheckPassword(existingUser, user.Password);

            if (!isCorrect)
                return new AuthResultDto()
                {
                    Errors = new List<string>()
                    {
                        "Invalid login request"
                    },
                    Success = false
                };

            var jwtToken = GenerateJwtToken(existingUser);

            return new AuthResultDto()
            {
                Success = true,
                Token = jwtToken,
                TrainerId = existingUser.Id
            };
        }

        public async Task<UserDetailsDto> GetUserDetails(ClaimsPrincipal userClaims)
        {
            var userId = GetUserId(userClaims);
            var user = await _userManager.FindByIdAsync(userId);
            return _mapper.Map<ApplicationUser, UserDetailsDto>(user);
        }

        public string GetUserId(ClaimsPrincipal userClaims)
        {
            return _userManager.GetUserId(userClaims);
        }

        private async Task<bool> CheckPassword(ApplicationUser user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        private string GenerateJwtToken(ApplicationUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _jwtConfig.Issuer,
                Audience = _jwtConfig.Audience,
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }

        private ApplicationUser ConvertFromRegistrationDtoToUser(UserRegistrationDto registrationDto)
        {
            return _mapper.Map<UserRegistrationDto, ApplicationUser>(registrationDto);
        }

        private async Task<ApplicationUser> GetUserByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }
    }
}
