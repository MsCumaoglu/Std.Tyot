using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface INewsService : IService<News>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        News isActiveTrue(News _model);
        News isActiveFalse(News _model);
    }
}
