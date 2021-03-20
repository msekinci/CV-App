using FluentValidation;
using MSE.CVApp.DTO.DTOs.CertificationDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class CertificationAddValidator : AbstractValidator<CertificationAddDTO>
    {
        public CertificationAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
