using FluentValidation;
using MSE.CVApp.DTO.DTOs.EducationDTOs;

namespace MSE.CVApp.Business.ValidationRules
{
    public class EducationUpdateValidator : AbstractValidator<EducationUpdateDTO>
    {
        public EducationUpdateValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id is not valid");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Sub Title is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Start Date is required");
        }
    }
}
