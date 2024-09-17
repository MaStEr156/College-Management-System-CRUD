using MVC_Session_1.Data;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Models;

namespace MVC_Session_1.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
        CollegeContext _context;
        public DepartmentRepo(CollegeContext context)
        {
            _context = context;
        }
        public void Add(Department dept)
        {
            _context.Add(dept);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var dept = _context.Departments.FirstOrDefault(x => x.DeptId == id);
            _context.Departments.Remove(dept);
            _context.SaveChanges();
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(x => x.DeptId == id);
        }

        public void Update(Department dept)
        {
            _context.Departments.Update(dept);
            _context.SaveChanges();
        }
    }
    public class DepartmentRepo2 : IDepartmentRepo
    {
        CollegeContext _context;
        public DepartmentRepo2(CollegeContext context)
        {
            _context= context;
        }
        static List<Department> _departments = new List<Department>()
        {
            new Department{DeptName = "Test", DeptId = 999, Capacity=100}
        };
        public void Add(Department dept)
        {
            _context.Add(dept);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var dept = _context.Departments.FirstOrDefault(x => x.DeptId == id);
            _context.Departments.Remove(dept);
            _context.SaveChanges();
        }

        public List<Department> GetAll()
        {
            return _departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(x => x.DeptId == id);
        }

        public void Update(Department dept)
        {
            _context.Departments.Update(dept);
            _context.SaveChanges();
        }
    }
}
