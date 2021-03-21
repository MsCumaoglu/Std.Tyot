using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IArticalTagMapService : IService<ArticalTagMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        ArticalTagMap isActiveTrue(ArticalTagMap _model);
        ArticalTagMap isActiveFalse(ArticalTagMap _model);
        ArticalTagMap isStartTrue(ArticalTagMap _model);
        ArticalTagMap isStartFalse(ArticalTagMap _model);
    }
}
