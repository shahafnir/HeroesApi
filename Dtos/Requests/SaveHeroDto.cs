using System.ComponentModel.DataAnnotations;
using HeroesApi.Dtos.Generic;
using HeroesApi.ModelsValidationAttributes;

namespace HeroesApi.Dtos.Requests
{
    public class SaveHeroDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [HeroAbilityValidation]
        public string Ability { get; set; }

        [Required]
        [HeroSuitColorsValidation]
        public IEnumerable<ColorDto> SuitColors { get; set; }
    }
}
