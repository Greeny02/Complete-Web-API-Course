﻿using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models.Validations
{
    public class Shirt_EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender))
            {
                if (shirt.Gender.Equals("male", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8 )
                {
                    return new ValidationResult("For mens shirts, the size has to be greater than or equal to 8.");
                }
                else if(shirt.Gender.Equals("female", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6)
                {
                    return new ValidationResult("For women shirts, the size has to be greate than or equal to 6.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
