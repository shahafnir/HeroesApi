using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using HeroesApi.Models.Heroes;

namespace HeroesApi.Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<Hero> Heroes { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
    }
}
