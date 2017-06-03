using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkDDD.Domain.Interfaces.Validations
{
    public interface IValidationResult
    {
        IValidationResult Add(string errorMessage);

        IValidationResult Add(IValidationError error);
    }
}
