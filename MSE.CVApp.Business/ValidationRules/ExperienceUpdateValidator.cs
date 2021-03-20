using FluentValidation;
using MSE.CVApp.DTO.DTOs.ExperienceDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class ExperienceUpdateValidator : AbstractValidator<ExperienceUpdateDTO>
    {
        public ExperienceUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id is not valid");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
