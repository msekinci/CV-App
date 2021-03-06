using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DataAccess.Interfaces;
using MSE.CVApp.Entities.Concrete;

namespace MSE.CVApp.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericRepository<AppUser> _genericRepository;
        private readonly IAppUserRepository _appUserRepository;
        public AppUserManager(IGenericRepository<AppUser> genericRepository, IAppUserRepository appUserRepository) :base(genericRepository)
        {
            _genericRepository = genericRepository;
            _appUserRepository = appUserRepository;
        }

        public bool CheckUser(string userName, string password)
        {
            return _appUserRepository.CheckUser(userName, password);
        }

        public AppUser FindByName(string userName)
        {
            return _appUserRepository.FindByName(userName);
        }
    }
}
