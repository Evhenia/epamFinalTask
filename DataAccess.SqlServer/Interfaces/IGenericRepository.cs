using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity GetFirstOrDefault(Func<TEntity, bool> predicate);

        void Add(TEntity entity);

        void Update(TEntity entityToUpdate);

        void Delete(TEntity entityToDelete);

        bool Exist(int id);
    }
}
