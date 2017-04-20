using TemplatesForBusiness.Domain.Interfaces.Validations;
using TemplatesForBusiness.Domain.Validations;

namespace TemplatesForBusiness.Domain.Interfaces
{
    public interface IEntity
    {
        ValidationResult Validate();
    }
}
