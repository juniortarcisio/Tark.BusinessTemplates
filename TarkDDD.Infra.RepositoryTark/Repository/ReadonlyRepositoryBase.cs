using System;
using TarkDDD.Domain.Interfaces;
using TarkDDD.Domain.Interfaces.Repositories;

namespace TarkDDD.Infra.Data.Repository
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
