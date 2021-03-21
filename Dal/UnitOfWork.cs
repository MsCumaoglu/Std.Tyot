using Core.Interfaces;
using Core.Interfaces.IRepositories;
using Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly TyottrContext _ctx = new TyottrContext();

        private ExamRepo _examRepo;

        // if else işlemi
        public IExamRepo Exam => _examRepo = _examRepo ?? new ExamRepo(_ctx);
        
        public void Commit()
        {
            _ctx.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _ctx.SaveChangesAsync();
        }

    }
}
