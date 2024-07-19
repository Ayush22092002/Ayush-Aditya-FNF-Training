using ClassLibrary1.Data;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services;

public class DataServices
{

    public interface IDataService
    {
        void AddNewStudent(Student student);
       List<Student> GetAllStudents();

        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }

    public class StudentDataService : IDataService
    {
        private readonly StudentDbContext _context;

        public StudentDataService(StudentDbContext context)
        {
            _context = context;
        }

        public void AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

        }
        public void DeleteStudent(int id)
        {
            var selected = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (selected != null)
            {

                _context.Students.Remove(selected);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception(" student not found");
            }
        }
        public List<Student> GetAllStudents() => _context.Students.ToList();

        public void UpdateStudent(Student student)
        {

            var rec = _context.Students.ToList().FirstOrDefault((s) => s.StudentId == student.StudentId);
            if (rec != null)
            {
            rec.StudentName = student.StudentName;
            rec.StudentId = student.StudentId;
            rec.StudentEmail = student.StudentEmail;
            rec.ContactNo = student.ContactNo;
            }else
                throw new Exception("Student not found to update");

            _context.SaveChanges();

        }
    }
}
