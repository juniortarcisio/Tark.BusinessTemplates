using System.Collections.Generic;
using System.Linq;
using TemplatesForBusiness.Domain.Interfaces.Validations;

namespace TemplatesForBusiness.Domain.Validations
{
    public class ValidationResult : IValidationResult
    {
        public List<IValidationError> Errors { get; set; }

        public bool IsValid { get { return !Errors.Any(); } }

        public string Message { get; set; }

        public ValidationResult()
        {
            Errors = new List<IValidationError>();
        }

        public IValidationResult Add(string errorMessage)
        {
            Errors.Add(new ValidationError(errorMessage));
            return this;
        }

        public IValidationResult Add(IValidationError error)
        {
            Errors.Add(error);
            return this;
        }
    }
}
