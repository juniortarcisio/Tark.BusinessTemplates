using TarkDDD.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace TarkDDD.Domain.Entities
{
    public class Country : IEntity, ISelfValidation
    {
        public Country() { }

        public Country(int countryId, string name, string countryCode)
        {
            CountryId = countryId;
            Name = name;
            CountryCode = countryCode;
        }

        public int CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength:2,MinimumLength=2)]
        public string CountryCode { get; set; }

        public int ContinentID { get; set; }

        public Validations.ValidationResult Validate()
        {
            return Validations.Validator.Validate(this);
        }
    }
}
