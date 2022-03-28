using Microsoft.AspNetCore.Mvc;

namespace MentorWebApp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
