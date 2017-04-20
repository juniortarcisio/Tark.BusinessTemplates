using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatesForBusiness.Domain.Interfaces;
using TemplatesForBusiness.Domain.Interfaces.Services;

namespace TemplatesForBusiness.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : IEntity
    {
        
    }
}
