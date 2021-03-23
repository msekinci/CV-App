using Dapper;
using MSE.CVApp.DataAccess.Interfaces;
using MSE.CVApp.Entities.Concrete;
using System.Data;

namespace MSE.CVApp.DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository : DPGenericRepository<AppUser>, IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection) :base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName and Password=@password", new
            {
                userName,
                password
            });
            return user != null;
        }

        public AppUser FindByName(string userName)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName", new
            {
                userName
            });
        }
    }
}
