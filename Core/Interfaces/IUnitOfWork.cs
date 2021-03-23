using Core.Interfaces.IRepositories;
using Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IExamRepo Exam { get; }
        IUniversityRepo University { get; }
        IFacultyRepo Faculty { get; }

        //IFacultyService Faculty { get; }

        // save changes işlemi yapmak için ( asekron )
        Task CommitAsync();
        // sekron save changes işlemi
        void Commit();

    }
}
