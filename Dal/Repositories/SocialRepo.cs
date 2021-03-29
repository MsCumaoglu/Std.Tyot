using Core.Interfaces.IRepositories;
using Core.Models;

namespace Dal.Repositories
{
    public class SocialRepo : Repository<Social>,
        ISocialRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public SocialRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}