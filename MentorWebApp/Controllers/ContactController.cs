using Microsoft.AspNetCore.Mvc;

namespace MentorWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
