using FluentValidation;
using MSE.CVApp.DTO.DTOs.ExperienceDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class ExperienceAddValidator : AbstractValidator<ExperienceAddDTO>
    {
        public ExperienceAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
