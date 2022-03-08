using HeroesApi.ModelsValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace HeroesApi.Models.Heroes
{
    public class Hero
    {
        [StringLength(50)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [HeroAbilityValidation]
        public string Ability { get; set; }

        public DateTime StartedTrainingAt { get; set; }

        [Required]
        [HeroSuitColorsValidation]
        public IEnumerable<HeroSuitColor> SuitColors { get; set; }

        public IEnumerable<HeroTraining> HeroTrainings { get; set; }

        public decimal StartingPower { get; set; }

        public decimal CurrentPower { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public void Train(int incrementPercent)
        {
            CurrentPower *= Convert.ToDecimal(1 + incrementPercent * 0.01);
        }
    }
}
