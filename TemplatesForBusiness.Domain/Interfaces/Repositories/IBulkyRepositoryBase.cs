using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesForBusiness.Domain.Interfaces.Repositories
{
    /// <summary>
    /// This repository pattern is intended to be used with bulky tables doesn't allow the method GetAll 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBulkyRepositoryBase<TEntity> where TEntity : IEntity
    {
        void GetById(params object[] keys);

        void Add(TEntity item);

        void Update(TEntity item);

        void Remove(TEntity item);

        void Remove(params object[] keys);
    }
}
