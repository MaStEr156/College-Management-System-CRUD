using MVC_Session_1.Models;

namespace MVC_Session_1.Interfaces
{
    public interface IStudentRepo
    {
        public List<Student> GetAll();
        public Student GetById(int id);
        public void Add(Student studentt);
        public void Update(Student studentt);
        public void DeleteById(int id);
    }
}
