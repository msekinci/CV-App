using MSE.CVApp.Entities.Concrete;
using System.Data;

namespace MSE.CVApp.DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository : DPGenericRepository<AppUser>
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection) :base(dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
