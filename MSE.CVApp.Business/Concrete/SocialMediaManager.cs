using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DataAccess.Interfaces;
using MSE.CVApp.Entities.Concrete;
using System.Collections.Generic;

namespace MSE.CVApp.Business.Concrete
{
    public class SocialMediaManager : GenericManager<SocialMediaIcon>, ISocialMediaService
    {
        private readonly IGenericRepository<SocialMediaIcon> _genericSocialMediaIconRepository;

        private readonly ISocialMediaRepository _socialMediaIconRepository;
        public SocialMediaManager(IGenericRepository<SocialMediaIcon> genericSocialMediaIconRepository, ISocialMediaRepository socialMediaIconRepository) : base(genericSocialMediaIconRepository)
        {
            _genericSocialMediaIconRepository = genericSocialMediaIconRepository;
            _socialMediaIconRepository = socialMediaIconRepository;
        }
        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
