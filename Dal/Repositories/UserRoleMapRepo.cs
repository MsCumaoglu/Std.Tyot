using Core.Interfaces.IRepositories;
using Core.Models;

namespace Dal.Repositories
{
    public class UserRoleMapRepo : Repository<UserRoleMap>,
        IUserRoleMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public UserRoleMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}