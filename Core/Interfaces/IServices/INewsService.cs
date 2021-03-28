using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface INewsService : IService<News>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        News IsActiveTrue(News model);
        News IsActiveFalse(News model);
    }
}
