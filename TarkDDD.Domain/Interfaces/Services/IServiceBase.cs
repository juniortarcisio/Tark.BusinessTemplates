using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : IEntity
    {

    }
}
