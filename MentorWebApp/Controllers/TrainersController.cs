using MentorWebApp.DAL;
using MentorWebApp.Models;
using MentorWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorWebApp.Controllers
{
    public class TrainersController : Controller
    {
        private readonly MentorDB _context;
        public TrainersController(MentorDB context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Trainer> trainers = await _context.Trainers.Include(t=>t.CourseCategory).OrderByDescending(t=>t.Id).Take(6).ToListAsync();
            return View(trainers);
        }
        public async Task<IActionResult>  Load()
        {
            IEnumerable<TrainerVM> trainers = await _context.Trainers.Include(t => t.CourseCategory).OrderByDescending(t => t.Id).Take(6).Select(x=>new TrainerVM
            {
                Id = x.Id,
                Facebook=x.Facebook,
                Image = x.Image,
                Info = x.Info,
                Instagram=x.Instagram,
                Linkedin=x.Linkedin,
                Name=x.Name,
                Surname=x.Surname,
                Twitter=x.Twitter,
                CourseCategory=new CourseCategoryVM
                {
                    Id=x.CourseCategory.Id,
                    Name=x.CourseCategory.Name
                }
                
            }).ToListAsync();
            return Json(trainers);
        }
    }
}
