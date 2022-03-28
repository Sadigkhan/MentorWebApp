using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Trainer> Trainer { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}
