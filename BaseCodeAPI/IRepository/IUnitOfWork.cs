using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCodeAPI.IRepository
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        void Save();
    }
}
