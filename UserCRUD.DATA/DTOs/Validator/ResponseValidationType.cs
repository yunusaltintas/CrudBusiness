using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.Attiributes;

namespace UserCRUD.DATA.DTOs.Validator
{
    public enum ResponseValidationType
    {
        [StringEnum("-101|is not null or empty.")]
        IsNotNullorEmpty = -101,

        [StringEnum("-102|Invalid Email.")]
        InvalidEmail = -102,

    }
}
