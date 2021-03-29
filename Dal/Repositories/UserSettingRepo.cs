using Core.Interfaces.IRepositories;
using Core.Models;

namespace Dal.Repositories
{
    public class UserSettingRepo : Repository<UserSetting>,
        IUserSettingRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public UserSettingRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}