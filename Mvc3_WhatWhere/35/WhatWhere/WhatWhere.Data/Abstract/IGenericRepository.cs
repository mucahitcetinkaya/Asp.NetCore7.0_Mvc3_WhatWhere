using System.Linq.Expressions;

namespace WhatWhere.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        Task<List<TEntity>> List(Expression<Func<TEntity, bool>> filter);

    }
}
