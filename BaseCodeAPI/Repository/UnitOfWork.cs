using BaseCodeAPI.IRepository;
using BaseCodeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCodeAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private TodoContext _context;
        private IStudentRepository _studentRepository;

        public UnitOfWork(TodoContext context)
        {
            _context = context;
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                return _studentRepository = _studentRepository ?? new StudentRepository(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
