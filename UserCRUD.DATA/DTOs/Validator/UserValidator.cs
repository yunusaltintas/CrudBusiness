using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.Extensions;

namespace UserCRUD.DATA.DTOs.Validator
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(o => o.Name)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Username)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Email)
               .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
               .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
               .EmailAddress().WithMessage(ResponseValidationType.InvalidEmail.GetStringValue());
            RuleFor(o => o.Website)
             .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
             .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Phone)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
        }
    }
    
}
