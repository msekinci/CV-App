using MSE.CVApp.Entities.Interfaces;
using System.Collections.Generic;

namespace MSE.CVApp.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
