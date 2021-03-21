using Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IExamRepo Exam { get; }

        // save changes işlemi yapmak için ( asekron )
        Task CommitAsync();
        // sekron save changes işlemi
        void Commit();

    }
}
