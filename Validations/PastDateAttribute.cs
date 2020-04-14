using System;
using System.ComponentModel.DataAnnotations;

namespace form_submission.Validations
{
    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime now = DateTime.UtcNow;
            DateTime input = Convert.ToDateTime(value);

            if (input < now)
            {
                return new ValidationResult("Date needs to be in the past");
            }
            else { return ValidationResult.Success; }
        }

    }
}