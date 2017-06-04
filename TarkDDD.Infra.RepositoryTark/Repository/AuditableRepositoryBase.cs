using System;
using TarkDDD.Domain.Interfaces;
using TarkDDD.Domain.Interfaces.Repositories;

namespace TarkDDD.Infra.Data.Repository
{
    public abstract class AuditableRepositoryBase<TEntity> : IAuditableRepositoryBase<TEntity> where TEntity : IEntity
    {
        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Disable(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public void Disable(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
