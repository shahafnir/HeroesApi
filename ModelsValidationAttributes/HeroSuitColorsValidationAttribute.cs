using System.ComponentModel.DataAnnotations;
using System.Reflection;
using HeroesApi.Dtos.Generic;

namespace HeroesApi.ModelsValidationAttributes
{
    public class ColorsValidForSuit
    {
        public static string White => "white";
        public static string Black => "black";
        public static string Yellow => "yellow";
        public static string Green => "green";
        public static string Blue => "blue";
        public static string Purple => "purple";
        public static string Red => "red";
        public static string Gold => "gold";
        public static string Brown => "brown";
        public static string Orange => "orange";
        public static string Silver => "silver";
        public static string Pink => "pink";
    }

    public class HeroSuitColorsValidationAttribute : ValidationAttribute
    {
        public string GetErrorMessage(string color, List<object> validColors)
        {
            string colors = "";
            foreach (string validColor in validColors)
                colors += validColor.ToString() + ", ";

            colors = colors.Remove(colors.Length - 2, 2) + ".";

            return $"Suit color: \'{color}\' is invalid. Colors available: {colors}";
        }

        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            var colors = value as List<ColorDto>;

            if (colors.Count != 2 || colors[0].ColorName == colors[1].ColorName)
                return new ValidationResult("Hero's Suit requires 2 different colors");

            Type type = new ColorsValidForSuit().GetType();
            PropertyInfo[] properties = type.GetProperties();

            var validColors = properties.Select(p => p.GetValue(new ColorsValidForSuit(), null)).ToList();

            foreach (ColorDto color in colors)
                if (!validColors.Contains(color.ColorName.ToLower()))
                    return new ValidationResult(GetErrorMessage(color.ColorName, validColors));

            return ValidationResult.Success;
        }
    }
}
