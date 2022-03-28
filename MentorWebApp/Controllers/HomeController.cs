using MentorWebApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace MentorWebApp.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }
    }
}
