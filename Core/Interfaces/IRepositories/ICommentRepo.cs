using Core.Models;

namespace Core.Interfaces.IRepositories
{
    public interface ICommentRepo : IRepository<Comment>
    {
        // burada Exam'e özel sorgular olursa yazılır (tanımlanır)
    }
}
