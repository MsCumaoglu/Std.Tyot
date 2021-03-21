using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class CommentRepo : Repository<Comment>,
        ICommentRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public CommentRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
