using MVC_Session_1.Models;

namespace MVC_Session_1.Interfaces
{
    public interface IDepartmentRepo
    {
        public List<Department> GetAll();
        public Department GetById(int id);
        public void Add(Department department);
        public void Update(Department department);
        public void DeleteById(int id);
    }
}
