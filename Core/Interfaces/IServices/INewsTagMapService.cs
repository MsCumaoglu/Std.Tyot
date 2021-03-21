using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface INewsTagMapService : IService<NewsTagMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        NewsTagMap isActiveTrue(NewsTagMap _model);
        NewsTagMap isActiveFalse(NewsTagMap _model);
    }
}
