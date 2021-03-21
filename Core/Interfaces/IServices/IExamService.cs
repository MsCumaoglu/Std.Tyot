using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.IServices
{
    public interface IExamService:IService<Exam>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Exam isActiveTrue(Exam _exam);
        Exam isActiveFalse(Exam _exam);
        Exam isStartTrue(Exam _exam);
        Exam isStartFalse(Exam _exam);

    }
}
