using Core.Models;

namespace Core.Interfaces.IRepositories
{
    public interface ICategoryRepo : IRepository<Category>
    {
        // burada Exam'e özel sorgular olursa yazılır (tanımlanır)
    }
}
