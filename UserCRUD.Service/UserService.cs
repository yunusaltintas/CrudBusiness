using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA.Entities;
using UserCRUD.BaseRepository;
using UserCRUD.Core.CommonResponseModel;

namespace UserCRUD.Service
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IBaseRepository<User> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<ReturnParameterModel<IEnumerable<User>>> GetAsync()
        {
            var query = await _unitOfWork.UserRepository.GetUsersAsync();
            if (query==null)
            {
                return new ReturnParameterModel<IEnumerable<User>>("Hata oluştu");
            }
            return new ReturnParameterModel<IEnumerable<User>>(query);
        }

        public async Task<ReturnParameterModel<User>> GetByIdUserAsync(int Id)
        {
            var query = await _unitOfWork.UserRepository.GetByIdUserAsync(Id);

            if (query == null)
            {
                return new ReturnParameterModel<User>("Hata oluştu");
            }
            return new ReturnParameterModel<User>(query);
        }
    }
}
