using TemplatesForBusiness.Domain.Interfaces;
using TemplatesForBusiness.Domain.Validations;

namespace TemplatesForBusiness.Domain.Entities
{
    public class Country : IEntity
    {
        public int CountryId { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }
        
        public ValidationResult Validate()
        {
            var result = new ValidationResult();

            if (Name.Length == 0)
                result.Add("Invalid Name");

            if (CountryCode.Length == 0)
                result.Add("Invalid Country Code");

            return result;
        }
    }
}
