using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA.Entities;

namespace UserCRUD.BaseRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetByIdUserAsync(int Id);
    }
}
