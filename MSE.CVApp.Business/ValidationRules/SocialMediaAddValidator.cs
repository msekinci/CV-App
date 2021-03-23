using FluentValidation;
using MSE.CVApp.DTO.DTOs.SocialMediaDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class SocialMediaAddValidator : AbstractValidator<SocialMediaAddDTO>
    {
        public SocialMediaAddValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Icon is required");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Link is required");
        }
    }
}
