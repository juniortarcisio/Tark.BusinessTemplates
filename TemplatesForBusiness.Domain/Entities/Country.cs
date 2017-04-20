using TemplatesForBusiness.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace TemplatesForBusiness.Domain.Entities
{
    public class Country : IEntity
    {
        [Key]
        public int CountryId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(2)]
        public string CountryCode { get; set; }
        
        public Validations.ValidationResult Validate()
        {
            return Validations.Validator.Validate(this);
        }
    }
}
