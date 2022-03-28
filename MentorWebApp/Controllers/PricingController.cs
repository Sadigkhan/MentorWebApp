using Microsoft.AspNetCore.Mvc;

namespace MentorWebApp.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
