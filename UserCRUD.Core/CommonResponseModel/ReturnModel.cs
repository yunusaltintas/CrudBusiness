using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.Core.CommonResponseModel
{
    public class ReturnModel : Return
    {
        public ReturnModel()
        {
            this.success = true;
        }
        public ReturnModel(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
            this.success = false;
        }
    }
}
