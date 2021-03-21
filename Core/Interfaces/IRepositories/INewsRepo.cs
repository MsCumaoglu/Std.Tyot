using Core.Models;

namespace Core.Interfaces.IRepositories
{
    public interface INewsRepo : IRepository<News>
    {
        // burada Exam'e özel sorgular olursa yazılır (tanımlanır)
    }
}
