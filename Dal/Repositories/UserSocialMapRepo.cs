using Core.Interfaces.IRepositories;
using Core.Models;

namespace Dal.Repositories
{
    public class UserSocialMapRepo : Repository<UserSocialMap>,
        IUserSocialMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public UserSocialMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}