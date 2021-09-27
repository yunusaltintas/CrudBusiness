using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.CommonResponseModel;
using UserCRUD.DATA.Entities;

namespace UserCRUD.Service
{
    public interface IUserService : IBaseService<User>
    {
        Task<ReturnParameterModel<IEnumerable<User>>> GetAsync();

        Task<ReturnParameterModel<User>> GetByIdUserAsync(int Id);
    }
}
