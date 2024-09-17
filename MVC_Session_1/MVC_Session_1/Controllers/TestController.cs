using Microsoft.AspNetCore.Mvc;

namespace MVC_Session_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Add(int id, string name)
        {
            HttpContext.Session.SetInt32("id", id);
            HttpContext.Session.SetString("Name", name);
            return View();
        }
        public IActionResult Get()
        {
            int id = HttpContext.Session.GetInt32("id")??0;
            string name = HttpContext.Session.GetString("Name");
            return Content($"{id}\n{name}");
        }
    }
}