using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICommentService : IService<Comment>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Comment isActiveTrue(Comment _model);
        Comment isActiveFalse(Comment _model);
        Comment isStartTrue(Comment _model);
        Comment isStartFalse(Comment _model);
    }
}
