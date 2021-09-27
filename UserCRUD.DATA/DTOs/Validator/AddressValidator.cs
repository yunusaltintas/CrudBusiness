using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.Extensions;

namespace UserCRUD.DATA.DTOs.Validator
{
    public class AddressValidator : AbstractValidator<AddressDTO>
    {
        public AddressValidator()
        {
            RuleFor(o => o.Street)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Suite)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.City)
               .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
               .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Zipcode)
               .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
               .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());

        }
    }
}
