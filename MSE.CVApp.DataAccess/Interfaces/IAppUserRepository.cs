using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.DataAccess.Interfaces
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        bool CheckUser(string userName, string password);
        AppUser FindByName(string userName);
    }
}
