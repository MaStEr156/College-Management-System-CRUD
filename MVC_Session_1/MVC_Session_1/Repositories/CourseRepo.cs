using Microsoft.EntityFrameworkCore;
using MVC_Session_1.Data;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Models;

namespace MVC_Session_1.Repositories
{
    public class CourseRepo: ICourseRepo
    {
        CollegeContext _context;
        public CourseRepo(CollegeContext context)
        {
            _context = context; ;
        }
        public void Add(Course Course)
        {
            _context.Add(Course);
            _context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return _context.Courses.Include(x => x.Department).ToList();
        }

        public Course GetById(int id)
        {
            return _context.Courses.Include(d => d.Department).FirstOrDefault(x => x.CourseId == id);
        }

        public void Update(Course Course)
        {
            _context.Courses.Update(Course);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var cor = _context.Courses.FirstOrDefault(x => x.CourseId == id);
            cor.Status = true;
            _context.SaveChanges();
        }
    }
}
