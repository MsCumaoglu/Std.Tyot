using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class CategoryRepo : Repository<Category>,
        ICategoryRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public CategoryRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
