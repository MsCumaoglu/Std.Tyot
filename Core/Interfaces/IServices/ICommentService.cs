using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICommentService : IService<Comment>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Comment IsActiveTrue(Comment model);
        Comment IsActiveFalse(Comment model);
    }
}
