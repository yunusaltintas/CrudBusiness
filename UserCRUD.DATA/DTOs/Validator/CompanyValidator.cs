using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.Extensions;

namespace UserCRUD.DATA.DTOs.Validator
{
    public class CompanyValidator : AbstractValidator<CompanyDTO>
    {
        public CompanyValidator()
        {
            RuleFor(o => o.Name)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.CatchPhrase)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Bs)
               .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
               .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
        }
    }
}
