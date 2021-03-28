using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork, IRepository<Comment> repository) : base(unitOfWork, repository)
        {
        }
        public Comment IsActiveFalse(Comment entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }
        public Comment IsActiveTrue(Comment entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}