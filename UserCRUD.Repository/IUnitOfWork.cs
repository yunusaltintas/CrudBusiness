using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.BaseRepository
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        Task CommitAsync();

        void Commit();
    }
}
