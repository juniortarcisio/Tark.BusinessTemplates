using System;
using TemplatesForBusiness.Domain.Interfaces;
using TemplatesForBusiness.Domain.Interfaces.Repositories;

namespace TemplatesForBusiness.Infra.RepositoryTark
{
    public abstract class ReadonlyRepositoryBase<TEntity> : IReadOnlyRepositoryBase<TEntity> where TEntity : IEntity
    {
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(params object[] keys)
        {
            throw new NotImplementedException();
        }
    }
}
