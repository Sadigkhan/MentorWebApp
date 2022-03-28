using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public int CourseCategoryId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(1000)]
        public string Info { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Twitter { get; set; }
        [StringLength(1000)]
        public string Facebook { get; set; }
        [StringLength(1000)]
        public string Instagram { get; set; }
        [StringLength(1000)]
        public string Linkedin { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}
