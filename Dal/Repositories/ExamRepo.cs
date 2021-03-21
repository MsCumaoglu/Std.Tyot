using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class ExamRepo : Repository<Exam>, IExamRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public ExamRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
