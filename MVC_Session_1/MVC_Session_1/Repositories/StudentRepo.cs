using Microsoft.EntityFrameworkCore;
using MVC_Session_1.Data;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Models;

namespace MVC_Session_1.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        CollegeContext _context;
        public StudentRepo(CollegeContext context)
        {
            _context = context;
        }
        public void Add(Student studentt)
        {
            _context.Students.Add(studentt);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var st = _context.Students.FirstOrDefault(s => s.Id == id);
            _context.Students.Remove(st);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.Include(s => s.Department).ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.Include(x => x.Department).FirstOrDefault(s => s.Id == id);
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}
