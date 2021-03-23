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
        private UniversityRepo _universityRepo;
        private FacultyRepo _facultyRepo;

        // if else işlemi
        public IExamRepo Exam => _examRepo = _examRepo ?? new ExamRepo(_ctx);
        public IUniversityRepo University => _universityRepo = _universityRepo ?? new UniversityRepo(_ctx);
        public IFacultyRepo Faculty => _facultyRepo = _facultyRepo ?? new FacultyRepo(_ctx);
        
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
