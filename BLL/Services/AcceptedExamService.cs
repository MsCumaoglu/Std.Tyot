using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class AcceptedExamService : Service<AcceptedExam>, IAcceptedExamService
    {
        public AcceptedExamService(IUnitOfWork unitOfWork, IRepository<AcceptedExam> repository) : base(unitOfWork, repository)
        {
        }

    }
}