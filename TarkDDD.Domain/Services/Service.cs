using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TarkDDD.Domain.Interfaces;
using TarkDDD.Domain.Interfaces.Repositories;
using TarkDDD.Domain.Interfaces.Services;
using TarkDDD.Domain.Validations;

namespace TarkDDD.Domain.Services
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : IEntity
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity GetById(params object[] keys)
        {
            return _repository.GetById(keys);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<TEntity> GetWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value)
        {
            return _repository.GetWhere(lambda, value);
        }

        public bool ExistsById(params object[] keys)
        {
            return _repository.ExistsById(keys);
        }

        public bool ExistsWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value)
        {
            return _repository.ExistsWhere(lambda, value);
        }

        public ValidationResult Add(TEntity item)
        {
            ValidationResult validationResult = new ValidationResult();

            if (item is ISelfValidation)
            {
                validationResult = (item as ISelfValidation).Validate();
                if (!validationResult.IsValid)
                    return validationResult;
            }

            _repository.Add(item);

            return validationResult;
        }

        public ValidationResult Update(TEntity item)
        {
            ValidationResult validationResult = new ValidationResult();

            if (item is ISelfValidation)
            {
                validationResult = (item as ISelfValidation).Validate();
                if (!validationResult.IsValid)
                    return validationResult;
            }

            _repository.Update(item);

            return validationResult;
        }

        public void Remove(TEntity item)
        {
            _repository.Remove(item);
        }

        public void RemoveById(params object[] keys)
        {
            _repository.RemoveById(keys);
        }
    }
}
