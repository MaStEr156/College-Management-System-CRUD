using Microsoft.AspNetCore.Mvc;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Models;
using MVC_Session_1.Repositories;

namespace MVC_Session_1.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepo _courseRepo;
        IDepartmentRepo _departmentRepo;

        public CourseController(ICourseRepo courseRepo, IDepartmentRepo departmentRepo)
        {
            _courseRepo = courseRepo;
            this._departmentRepo = departmentRepo;
        }

        public IActionResult Create()
        {
            ViewBag.depts = _departmentRepo.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Course course)
        {

            if (ModelState.IsValid)
            {

                _courseRepo.Add(course);
                return RedirectToAction("Index");

            }

            else
            {
                ViewBag.depts = _departmentRepo.GetAll();
                return View(course);
            }
        }


        public IActionResult Details(int? id)
        {
            Course course = _courseRepo.GetById(id.Value);

            if (id != null)
            {
                if (course != null)
                {

                    ViewData["course"] = course;
                    return View(course);
                }

                return NotFound();
            }

            return BadRequest();

        }


        public IActionResult Delete(int id)
        {
            var course = _courseRepo.GetById(id);
            return View(course);

        }

        public IActionResult DeleteConfirm(int id)
        {
            _courseRepo.DeleteById(id);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewBag.depts = _departmentRepo.GetAll();
            return View(course);
        }

        [HttpPost]


        public IActionResult Update(Course course)
        {

            if (course != null)
            {
                if (ModelState.IsValid)
                {
                    _courseRepo.Update(course);
                    return RedirectToAction("Index");
                }
                ViewBag.depts = _departmentRepo.GetAll();
                return View(course);
            }
            return NotFound();
        }


        public IActionResult Index()
        {
            var result = _courseRepo.GetAll();
            return View(result);
        }
    }
}
