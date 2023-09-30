using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly WhatWhereContext _context;

        public EfCoreGenericRepository(WhatWhereContext context)
        {
            _context = context;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
