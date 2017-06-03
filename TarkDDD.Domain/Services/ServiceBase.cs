using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarkDDD.Domain.Interfaces;
using TarkDDD.Domain.Interfaces.Services;

namespace TarkDDD.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : IEntity
    {
        
    }
}
