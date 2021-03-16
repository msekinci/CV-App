using MSE.CVApp.DTO.Interfaces;

namespace MSE.CVApp.DTO.DTOs.SocialMediaDTOs
{
    public class SocialMediaListDTO : IDTO
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
