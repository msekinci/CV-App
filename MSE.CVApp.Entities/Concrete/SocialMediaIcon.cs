using MSE.CVApp.Entities.Interfaces;

namespace MSE.CVApp.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("SocialMediaIcons")]
    public class SocialMediaIcon : IEntity
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
