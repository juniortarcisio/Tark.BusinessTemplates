using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnnotations = System.ComponentModel.DataAnnotations;

namespace TemplatesForBusiness.Domain.Validations
{
    public static class Validator
    {
        public static ValidationResult Validate(object instance)
        {
            var valContext = new DataAnnotations.ValidationContext(instance);
            DataAnnotations.Validator.ValidateObject(instance, valContext);

            List<DataAnnotations.ValidationResult> valResults = new List<DataAnnotations.ValidationResult>();
            DataAnnotations.Validator.TryValidateObject(instance, valContext, valResults, true);

            ValidationResult result = new ValidationResult();
            
            foreach (var item in valResults)
                result.Add(item.ErrorMessage);
            
            return result;
        }
    }
}
