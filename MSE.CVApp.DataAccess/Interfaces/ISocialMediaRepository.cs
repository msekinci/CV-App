using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.DataAccess.Interfaces
{
    public interface ISocialMediaRepository : IGenericRepository<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
