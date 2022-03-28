using MentorWebApp.Models;

namespace MentorWebApp.ViewModels
{
    public class TrainerVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Info { get; set; }
        public string Image { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public CourseCategoryVM CourseCategory { get; set; }
    }
}
