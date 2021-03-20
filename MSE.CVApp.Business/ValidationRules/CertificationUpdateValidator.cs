using FluentValidation;
using MSE.CVApp.DTO.DTOs.CertificationDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class CertificationUpdateValidator : AbstractValidator<CertificationUpdateDTO>
    {
        public CertificationUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id is not valid");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
