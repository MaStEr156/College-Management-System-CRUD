using Microsoft.AspNetCore.Mvc;
using MVC_Session_1.Data;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Models;
using MVC_Session_1.Repositories;

namespace MVC_Session_1.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentRepo _deptRepo;
        public DepartmentController(IDepartmentRepo Ideptrepo)
        {
            _deptRepo = Ideptrepo;
        }


        public IActionResult Index()
        {
            var result = _deptRepo.GetAll();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department dept)
        {
            if (dept != null && ModelState.IsValid)
            {
                _deptRepo.Add(dept);
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        public IActionResult Details(int? id)
        {
            if(id != null)
            {
                var dept = _deptRepo.GetById(id.Value);
                if(dept != null)
                    return View(dept);

                return NotFound();
            }
            return BadRequest();
        }

        public IActionResult Update(int? id)
        {
            if(id != null)
            {
                var dept = _deptRepo.GetById(id.Value);
                if(dept != null)
                {
                    return View(dept);
                }
                return NotFound();
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Update(Department dept)
        {
            if (ModelState.IsValid && dept != null)
            {
                _deptRepo.Update(dept);
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        public IActionResult Delete(int? id)
        {
            if(id != null)
            {
                var dept = _deptRepo.GetById(id.Value);
                if(dept != null)
                    return View(dept);

                return NotFound();
            }
            return BadRequest();
        }

        public IActionResult DeleteConfirm(int? id)
        {
            if(id != null)
            {
                _deptRepo.DeleteById(id.Value);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }


        /*public string Create(int id, string name, int capacity)
        {
            Department newDepartment = new Department() { DeptId = id, DeptName = name, Capacity = capacity};
            _context.Add(newDepartment);
            _context.SaveChanges();
            
            return "Added";
        }*/

       /* public IActionResult Create()
        {
            return View();
        }*/

       /* [HttpPost]
        public IActionResult Create(Department dept)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(dept);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dept);
            
        }
*/


        /*public IActionResult Details(int? id)
        {
            Department dept = _context.Departments.SingleOrDefault(x => x.DeptId == id);

            if (id != null)
            {
                if (dept != null)
                {
                    ViewData["department"] = dept;
                    return View(dept);
                }

                return NotFound();
            }

            return BadRequest();

        }*/
        /*public string GetDetails(int deptId)
        {
            var dept = _context.Departments.FirstOrDefault(x => x.DeptId == deptId);
            string res = $"Dept Id: {dept.DeptId}\nDept Name: {dept.DeptName}\nDept Capacity: {dept.Capacity}";
            return res;
        }*/


        /*public IActionResult Update(int id, string name, int capacity)
        {
            var dept = _context.Departments.FirstOrDefault(x => x.DeptId == id);
            if (dept != null)
            {
                dept.DeptName = name;
                dept.Capacity = capacity;
                _context.SaveChanges();
                string res = "Updated Successfully";
                return Content(res);
            }
            return BadRequest();
        }*/



        /*public IActionResult Update(int id)
        {
            var dept = _context.Departments.SingleOrDefault(x => x.DeptId == id);
            if (dept == null)
            {
                return NotFound();
            }
            return View(dept);
        }*/


        /*[HttpPost]
        public IActionResult Update(Department model)
        {
            var dept = _context.Departments.SingleOrDefault(x => x.DeptId == model.DeptId);

            if (dept != null)
            {
                if (ModelState.IsValid)
                {
                    dept.DeptName = model.DeptName;
                    dept.Capacity = model.Capacity;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(dept);
            }

            return NotFound();
        }*/


        /*public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var dept = _context.Departments.FirstOrDefault(x => x.DeptId == id);
                if(dept != null)
                {
                    _context.Remove(dept);
                    _context.SaveChanges();

                    string res = "Deleted!";
                    return Content(res);
                }
                return NotFound();
                
            }
            return BadRequest();
            
        }*/



        /*public IActionResult Delete(int id)
        {
            var dept = _context.Departments.SingleOrDefault(x => x.DeptId == id);
            if(dept != null)
                return View(dept);

            return NotFound();

        }*/

       /* public IActionResult ConfirmDelete(int id)
        {
            var dept = _context.Departments.SingleOrDefault(x => x.DeptId == id);
            if(dept != null)
            {
                _context.Departments.Remove(dept);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return NotFound();

            
        }*/



    }
}
