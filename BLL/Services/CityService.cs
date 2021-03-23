using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class CityService : Service<City>, ICityService
    {
        public CityService(IUnitOfWork unitOfWork, IRepository<City> repository) : base(unitOfWork, repository)
        {
        }

        //public City isActiveFalse(City _entity)
        //{
        //    _entity.IsActive = false;
        //    return Update(_entity);
        //}
        //public City isActiveTrue(City _entity)
        //{
        //    _entity.IsActive = true;
        //    return Update(_entity);
        //}
    }

    
    

}
