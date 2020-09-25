using BaseCodeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCodeAPI.IRepository
{
    public interface IStudentRepository
    {
        Student GetStudentById(int Id);
        IList<Student> GetAllStudents();
        void AddStudent(Student student);
    }
}
