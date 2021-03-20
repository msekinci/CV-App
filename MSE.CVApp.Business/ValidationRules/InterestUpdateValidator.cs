using FluentValidation;
using MSE.CVApp.DTO.DTOs.InterestDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class InterestUpdateValidator : AbstractValidator<InterestUpdateDTO>
    {
        public InterestUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id is not valid");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
