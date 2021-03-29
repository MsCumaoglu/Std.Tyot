using Core.Interfaces.IRepositories;
using Core.Models;

namespace Dal.Repositories
{
    public class UserRepo : Repository<User>,
        IUserRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public UserRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}