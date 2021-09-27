using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA;
using UserCRUD.DATA.Entities;

namespace UserCRUD.BaseRepository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly UserDbContext context;
        private readonly DbSet<User> _dbUser;
        public UserRepository(UserDbContext context) : base(context)
        {
            this.context = context;
            _dbUser = context.Set<User>();
        }

        public async Task<User> GetByIdUserAsync(int Id)
        {
            var query = await _dbUser.Include(p => p.Address).ThenInclude(p => p.Geo).Include(p => p.Company).FirstOrDefaultAsync(p => p.Id == Id);
            return query;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var query = await _dbUser.Include(p => p.Address).ThenInclude(p => p.Geo).Include(p => p.Company).ToListAsync();
            return query;
        }
        
    }
}
