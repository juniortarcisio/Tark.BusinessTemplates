using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatesForBusiness.Domain.Interfaces.Repositories;

namespace TemplatesForBusiness.Infra.RepositoryTark
{
    public class AuditableRepositoryBase<TEntity> : IAuditableRepositoryBase<TEntity> where TEntity : class
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
