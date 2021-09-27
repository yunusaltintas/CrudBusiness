using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA;

namespace UserCRUD.BaseRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserDbContext _context;
        private UserRepository _userRepository;

        public UnitOfWork(UserDbContext context)
        {
            _context = context;
        }
        public IUserRepository UserRepository => _userRepository = _userRepository ?? new UserRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
