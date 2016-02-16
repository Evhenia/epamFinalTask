using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.DomainLogic.Interfaces.Services
{
    public interface IEntityService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
        
        //метод CreateEntity возвращает id созданной сущности
        int Create(TEntity createdEntity);

        bool Edit(TEntity editedEntity);

        bool Delete(TEntity deletedEntity);
    }
}
