using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatesForBusiness.Domain.Interfaces.Repositories;

namespace TemplatesForBusiness.Infra.RepositoryTark
{
    public class BulkyRepository<TEntity> : IBulkyRepositoryBase<TEntity> where TEntity : class
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
