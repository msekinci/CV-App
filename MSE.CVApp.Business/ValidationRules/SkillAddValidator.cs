using FluentValidation;
using MSE.CVApp.DTO.DTOs.SkillDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class SkillAddValidator : AbstractValidator<SkillAddDTO>
    {
        public SkillAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
