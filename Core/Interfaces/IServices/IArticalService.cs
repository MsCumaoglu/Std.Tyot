using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IArticalService : IService<Artical>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Artical isActiveTrue(Artical _artical);
        Artical isActiveFalse(Artical _artical);
        Artical isStartTrue(Artical _artical);
        Artical isStartFalse(Artical _artical);
    }
}
