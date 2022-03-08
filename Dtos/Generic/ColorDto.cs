using System.ComponentModel.DataAnnotations;

namespace HeroesApi.Dtos.Generic
{
    public class ColorDto
    {
        [Required]
        [StringLength(50)]
        public string ColorName { get; set; }
    }
}
