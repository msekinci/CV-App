using FluentValidation;
using MSE.CVApp.DTO.DTOs.InterestDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class InterestAddValidator : AbstractValidator<InterestAddDTO>
    {
        public InterestAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
