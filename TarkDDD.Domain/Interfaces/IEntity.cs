using TarkDDD.Domain.Validations;

namespace TarkDDD.Domain.Interfaces
{
    public interface IEntity
    {
        ValidationResult Validate();
    }
}
