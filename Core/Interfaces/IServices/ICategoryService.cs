using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICategoryService : IService<Category>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Category IsActiveTrue(Category model);
        Category IsActiveFalse(Category model);

    }
}
