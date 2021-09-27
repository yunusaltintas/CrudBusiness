using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.Extensions;

namespace UserCRUD.DATA.DTOs.Validator
{
    public class GeoValidator : AbstractValidator<GeoDTO>
    {
        public GeoValidator()
        {
            RuleFor(o => o.Lat)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
            RuleFor(o => o.Lng)
                .NotEmpty().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue())
                .NotNull().WithMessage(ResponseValidationType.IsNotNullorEmpty.GetStringValue());
        }
    }
}
