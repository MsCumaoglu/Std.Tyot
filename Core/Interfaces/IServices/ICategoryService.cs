using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICategoryService : IService<Category>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Category isActiveTrue(Category _model);
        Category isActiveFalse(Category _model);
        Category isStartTrue(Category _model);
        Category isStartFalse(Category _model);
    }
}
