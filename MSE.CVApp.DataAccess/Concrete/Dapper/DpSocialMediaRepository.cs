using Dapper;
using MSE.CVApp.DataAccess.Interfaces;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MSE.CVApp.DataAccess.Concrete.Dapper
{
    public class DpSocialMediaRepository : DPGenericRepository<SocialMediaIcon>, ISocialMediaRepository
    {
        private readonly IDbConnection _connection;
        public DpSocialMediaRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _connection.Query<SocialMediaIcon>("select * from SocialMediaIcons where AppUserId=@id", new
            {
                id = userId
            }).ToList();
        }
    }
}
