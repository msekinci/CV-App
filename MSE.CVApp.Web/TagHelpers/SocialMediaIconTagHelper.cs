using AutoMapper;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MSE.CVApp.Business.Interfaces;

namespace MSE.CVApp.Web.TagHelpers
{
    [HtmlTargetElement("GetIcons")]
    public class SocialMediaIconTagHelper : TagHelper
    {
        private readonly IAppUserService _appUserService;
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaIconTagHelper(IAppUserService appUserService, ISocialMediaService socialMediaService, IMapper mapper)
        {
            _appUserService = appUserService;
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        public int AppUserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons = _socialMediaService.GetByUserId(AppUserId);
            string data = "<div class='social-icons'";
            foreach (var item in icons)
            {
                data += $@"<a class='social-icon' href='{item.Link}'><i class='{item.Icon}'></i></a>";
            }
            data += "</div>";
            output.Content.SetHtmlContent(data);
            base.Process(context, output);
        }
    }
}
