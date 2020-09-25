using BaseCodeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCodeAPI.IService
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        IList<Student> GetAllStudents();
        Student GetStudentById(int Id);
    }
}
