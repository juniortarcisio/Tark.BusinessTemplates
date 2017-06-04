using System.Collections.Generic;
using System.Linq;

namespace TarkDDD.Domain.Validations
{
    public class ValidationResult 
    {
        public List<ValidationError> Errors { get; private set; }

        public bool IsValid { get { return !Errors.Any(); } }

        public string Message { get; set; }

        public ValidationResult()
        {
            Errors = new List<ValidationError>();
        }

        public ValidationResult Add(string errorMessage)
        {
            Errors.Add(new ValidationError(errorMessage));
            return this;
        }

        public ValidationResult Add(ValidationError error)
        {
            Errors.Add(error);
            return this;
        }

        public ValidationResult Add(ValidationResult validationResult)
        {
            Errors.AddRange(validationResult.Errors);
            return this;
        }
    }
}
