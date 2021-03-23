using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        bool CheckUser(string userName, string password);
        AppUser FindByName(string userName);
    }
}
