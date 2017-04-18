using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesForBusiness.Domain.Interfaces.Repositories
{
    /// <summary>
    /// The default repository pattern. 
    /// I'm using params as the Key for ID, intending to make it possible to works with legacy tables 
    /// which could contains composite PKs or not integer type fields
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void GetAll();

        void GetById(params object[] keys);

        void Add(TEntity item);

        void Update(TEntity item);

        void Remove(TEntity item);

        void Remove(params object[] keys);
    }
}
