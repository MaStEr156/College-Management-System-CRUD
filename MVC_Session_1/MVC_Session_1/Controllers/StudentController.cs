using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Session_1.Data;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Models;
using MVC_Session_1.Repositories;

namespace MVC_Session_1.Controllers
{
    public class StudentController : Controller
    {
        //CollegeContext _context = new CollegeContext();
        IStudentRepo _studentRepo;
        IDepartmentRepo _departmentRepo;
        public StudentController(IStudentRepo studentRepo, IDepartmentRepo departmentRepo)
        {
            _studentRepo = studentRepo;
            _departmentRepo = departmentRepo;
        }

        public IActionResult Index()
        {
            var result = _studentRepo.GetAll();
            return View(result);
        }

        public IActionResult Create()
        {
            ViewBag.depts = _departmentRepo.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                _studentRepo.Add(st);
                return RedirectToAction("Index");
            }
            ViewBag.depts = _departmentRepo.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var student = _studentRepo.GetById(id.Value);
                if(student != null)
                {
                    ViewData["student"] = student;
                    return View(student);
                }
                return NotFound();
            }
            return BadRequest();
        }

        public IActionResult Update(int? id)
        {
            if(id != null)
            {
                var student = _studentRepo.GetById(id.Value);
                if(student != null)
                {
                    ViewBag.depts = _departmentRepo.GetAll();
                    return View(student);
                }
                return NotFound(id.Value);

            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (student != null)
            {
                _studentRepo.Update(student);
                return RedirectToAction("Index");
            }
            return BadRequest(student);
        }

        public IActionResult Delete(int? id)
        {
            if(id != null)
            {
                var student = _studentRepo.GetById(id.Value);
                if(student != null)
                {
                    return View(student);
                }
                return NotFound();
            }
            return BadRequest();
        }

        public IActionResult DeleteConfirm(int? id)
        {
            if(id != null)
            {
                _studentRepo.DeleteById(id.Value);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }




        /*public IActionResult Create()
        {
            ViewBag.depts = _context.Departments.ToList();
            return View();

        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {

                var emailExists = _context.Students.Any(x => x.Email == st.Email);
                if (emailExists)
                {
                    return Json($"Email is Already Used");
                }
                else
                {
                    _context.Students.Add(st);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ViewBag.depts = _context.Departments.ToList();
                return View(st);
            }
        }*/

        /*public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            _context.Students.Add(st);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }*/


        /*public string Create(string name, int age, int deptId)
        {
            Student newStudent = new Student() {Name = name, Age = age, DeptId = deptId };
            _context.Students.Add(newStudent);
            _context.SaveChanges();
            return "Added";
        }*/



        /*public IActionResult Details(int? id)
        {
            Student st = _context.Students.SingleOrDefault(s => s.Id == id);
            if (id != null)
            {
                if (st != null)
                {
                    ViewData["student"] = st;
                    return View(st);
                }

                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }*/


        /*public string GetDetails(int studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
            string res = $"Name: {student.Name}\nAge: {student.Age}\nDepartment Id: {student.DeptId}";
            return res;
        }*/


        /*public string Update(int id, string name, int age, int deptId)
        {
            var std = _context.Students.FirstOrDefault(x => x.Id == id);
            if (std != null)
            {
                std.Name = name;
                std.Age = age;
                std.DeptId = deptId;
                _context.SaveChanges();
            }

            return "Updated!";
        }*/
        /*public string Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            _context.Remove(student);
            _context.SaveChanges();

            return "Deleted!";
        }*/


        /*public IActionResult Delete(int id)
        {
            var st = _context.Students.SingleOrDefault(x => x.Id == id);

            return View(st);


        }*/
        /*public IActionResult DeleteConfirm(int id)
        {
            var st = _context.Students.SingleOrDefault(x => x.Id == id);

            _context.Students.Remove(st);
            _context.SaveChanges();
            return RedirectToAction("index");
        }*/
    }
}