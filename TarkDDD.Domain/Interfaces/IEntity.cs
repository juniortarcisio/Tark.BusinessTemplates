using TarkDDD.Domain.Interfaces.Validations;
using TarkDDD.Domain.Validations;

namespace TarkDDD.Domain.Interfaces
{
    public interface IEntity
    {
        ValidationResult Validate();
    }
}
