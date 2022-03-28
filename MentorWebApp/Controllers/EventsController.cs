using Microsoft.AspNetCore.Mvc;

namespace MentorWebApp.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
