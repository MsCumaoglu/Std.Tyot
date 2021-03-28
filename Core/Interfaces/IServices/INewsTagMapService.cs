using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface INewsTagMapService : IService<NewsTagMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        NewsTagMap IsActiveTrue(NewsTagMap model);
        NewsTagMap IsActiveFalse(NewsTagMap model);
    }
}
