using FluentValidation;
using MSE.CVApp.DTO.DTOs.AppUserDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class AppUserUpdateValidator : AbstractValidator<AppUserUpdateDTO>
    {
        public AppUserUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id is not valid");
        }
    }
}
