using System;
using TemplatesForBusiness.Domain.Interfaces;
using TemplatesForBusiness.Domain.Interfaces.Repositories;

namespace TemplatesForBusiness.Infra.RepositoryTark
{
    public abstract class BulkyRepository<TEntity> : IBulkyRepositoryBase<TEntity> where TEntity : IEntity
    {
        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void GetById(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public void Remove(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
