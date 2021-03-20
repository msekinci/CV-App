using FluentValidation;
using MSE.CVApp.DTO.DTOs.SkillDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class SkillUpdateValidator : AbstractValidator<SkillUpdateDTO>
    {
        public SkillUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id is not valid");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
