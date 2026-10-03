using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public static class ValidationHelper
    {
        public static bool Validate(
            object model,
            out List<string> errors)
        {
            var context = new ValidationContext(model);

            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(
                model,
                context,
                results,
                true);

            errors = results
                .Select(x => x.ErrorMessage)
                .ToList();

            return isValid;
        }
    }
}
