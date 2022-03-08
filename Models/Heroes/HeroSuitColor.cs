using System.ComponentModel.DataAnnotations;

namespace HeroesApi.Models.Heroes
{
    public class HeroSuitColor
    {
        public Guid HeroId { get; set; }

        [Required]
        [StringLength(50)]
        public string ColorName { get; set; }
    }
}