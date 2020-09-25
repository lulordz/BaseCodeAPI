using BaseCodeAPI.IRepository;
using BaseCodeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseCodeAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private TodoContext _context;

        public StudentRepository(TodoContext context)
        {
            _context = context;
        }
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public IList<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int Id)
        {
            var student = _context.Students.Where(x => x.StudentId == Id).FirstOrDefault();
            return student;
        }
    }
}
