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

        public Exam isActiveFalse(Exam exam)
        {
            exam.IsActive = false;
            return Update(exam);
        }

        public Exam isActiveTrue(Exam exam)
        {
            exam.IsActive = true;
            return Update(exam);
        }

        public Exam isStartFalse(Exam exam)
        {
            exam.IsStart = false;
            return Update(exam);
        }

        public Exam isStartTrue(Exam exam)
        {
            exam.IsStart = true;
            return Update(exam);
        }
    }
}
