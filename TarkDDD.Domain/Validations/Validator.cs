using System.Collections.Generic;
using DataAnnotations = System.ComponentModel.DataAnnotations;

namespace TarkDDD.Domain.Validations
{
    public static class Validator
    {
        public static ValidationResult Validate(object instance)
        {
            var valContext = new DataAnnotations.ValidationContext(instance);

            List<DataAnnotations.ValidationResult> valResults = new List<DataAnnotations.ValidationResult>();
            DataAnnotations.Validator.TryValidateObject(instance, valContext, valResults, true);

            ValidationResult result = new ValidationResult();
            
            foreach (var item in valResults)
                result.Add(item.ErrorMessage);
            
            return result;
        }
    }
}
