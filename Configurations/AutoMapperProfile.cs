using AutoMapper;
using HeroesApi.Models.Heroes;
using HeroesApi.Dtos.Requests;
using HeroesApi.Dtos.Responses;
using HeroesApi.Models.IdentityModels;
using HeroesApi.Dtos.Generic;

namespace HeroesApi.Configurations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegistrationDto, ApplicationUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email));

            CreateMap<ApplicationUser, UserDetailsDto>();

            CreateMap<SaveHeroDto, Hero>()
                .ForMember(dest => dest.StartedTrainingAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.Ignore());

            CreateMap<Hero, HeroDetailsDto>()
            .ForMember(dest => dest.TrainerId, opt => opt.MapFrom(src => src.ApplicationUserId));

            CreateMap<HeroSuitColor, ColorDto>();
            CreateMap<ColorDto, HeroSuitColor>();
        }
    }
}
