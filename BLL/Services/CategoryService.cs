using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }
        public Category IsActiveFalse(Category entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }
        public Category IsActiveTrue(Category entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}