using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.SocialMediaDTOs
{
    public class SocialMediaAddDTO : IDTO
    {
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
