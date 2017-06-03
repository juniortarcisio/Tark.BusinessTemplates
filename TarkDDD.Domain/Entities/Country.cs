using TarkDDD.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace TarkDDD.Domain.Entities
{
    public class Country : IEntity
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2)]
        public string CountryCode { get; set; }
        
        public Validations.ValidationResult Validate()
        {
            return Validations.Validator.Validate(this);
        }
    }
}
