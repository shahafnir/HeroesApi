using System.ComponentModel.DataAnnotations;

namespace HeroesApi.ModelsValidationAttributes
{
    public static class Ability
    {
        public static string Attacker => "attacker";
        public static string Defender => "defender";
    }

    public class HeroAbilityValidationAttribute : ValidationAttribute
    {
        private string getErrorMessage() =>
            $"Hero's ability can only be \'Attacker\' or \'Defender\'.";

        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            string ability = (value as string).ToLower();

            if (ability != Ability.Attacker && ability != Ability.Defender)
                return new ValidationResult(getErrorMessage());

            return ValidationResult.Success;
        }
    }
}
