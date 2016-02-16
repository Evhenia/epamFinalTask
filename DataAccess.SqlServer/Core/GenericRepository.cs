using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SqlServer.Interfaces;

namespace DataAccess.SqlServer.Core
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly PeriodicalsDBContext _context;

        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(PeriodicalsDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual TEntity GetFirstOrDefault(Func<TEntity, bool> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual bool Exist(int id)
        {
            return _dbSet.Find(id) != null;
        }
    }
}
