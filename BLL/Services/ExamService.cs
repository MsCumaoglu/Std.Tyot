using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ExamService : Service<Exam>, IExamService
    {
        public ExamService(IUnitOfWork unitOfWork, IRepository<Exam> repository) : base(unitOfWork, repository)
        {
        }

        public Exam isActiveFalse(Exam _exam)
        {
            _exam.IsActive = false;
            return Update(_exam);
        }

        public Exam isActiveTrue(Exam _exam)
        {
            _exam.IsActive = true;
            return Update(_exam);
        }

        public Exam isStartFalse(Exam _exam)
        {
            _exam.IsStart = false;
            return Update(_exam);
        }

        public Exam isStartTrue(Exam _exam)
        {
            _exam.IsStart = true;
            return Update(_exam);
        }
    }
}
