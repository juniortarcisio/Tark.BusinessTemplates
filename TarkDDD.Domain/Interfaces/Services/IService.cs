using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TarkDDD.Domain.Interfaces.Repositories;

namespace TarkDDD.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : IEntity
    {   
        TEntity GetById(params object[] keys);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value);

        bool ExistsById(params object[] keys);

        bool ExistsWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value);

        Validations.ValidationResult Add(TEntity item);

        Validations.ValidationResult Update(TEntity item);

        void Remove(TEntity item);

        void RemoveById(params object[] keys);
    }
}
