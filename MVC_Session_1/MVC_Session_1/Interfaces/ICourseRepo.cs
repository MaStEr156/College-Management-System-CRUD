using MVC_Session_1.Models;

namespace MVC_Session_1.Interfaces
{
    public interface ICourseRepo
    {
        public List<Course> GetAll();
        public Course GetById(int id);
        public void Add(Course Course);
        public void Update(Course Course);
        public void DeleteById(int id);
    }
}
