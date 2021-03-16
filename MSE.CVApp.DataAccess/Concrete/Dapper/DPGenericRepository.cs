using Dapper.Contrib.Extensions;
using MSE.CVApp.DataAccess.Interfaces;
using MSE.CVApp.Entities.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MSE.CVApp.DataAccess.Concrete.Dapper
{
    public class DPGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IDbConnection _dbConnection;

        public DPGenericRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Delete(TEntity entity)
        {
            _dbConnection.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _dbConnection.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbConnection.Get<TEntity>(id);
        }

        public void Insert(TEntity entity)
        {
            _dbConnection.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _dbConnection.Update(entity);
        }
    }
}
