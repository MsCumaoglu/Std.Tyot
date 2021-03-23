using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICityService : IService<City>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        //City isActiveTrue(City _model);
        //City isActiveFalse(City _model);
    }

}
