using Core.Models;

namespace Core.Interfaces.IRepositories
{
    public interface IUserRepo : IRepository<User>
    {
        // burada Exam'e özel sorgular olursa yazılır (tanımlanır)
    }
}