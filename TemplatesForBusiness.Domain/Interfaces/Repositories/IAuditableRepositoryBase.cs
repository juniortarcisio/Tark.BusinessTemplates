using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesForBusiness.Domain.Interfaces.Repositories
{
    /// <summary>
    /// This repository pattern is intended to be used on tables where the history belongs to the same table and 
    /// registers are never deleted, only virtualy.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IAuditableRepositoryBase<TEntity> where TEntity : IEntity
    {
        void GetAll();

        void GetById(params object[] keys);

        void Add(TEntity item);

        void Update(TEntity item);

        void Disable(TEntity item);

        void Disable(params object[] keys);
    }
}
