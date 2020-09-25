using BaseCodeAPI.IRepository;
using BaseCodeAPI.IService;
using BaseCodeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCodeAPI.Service
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork uow;

        public StudentService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public void AddStudent(Student student)
        {
            uow.StudentRepository.AddStudent(student);
            uow.Save();
        }

        public IList<Student> GetAllStudents()
        {
            return uow.StudentRepository.GetAllStudents();
        }

        public Student GetStudentById(int Id)
        {
            return uow.StudentRepository.GetStudentById(Id);
        }
    }
}
