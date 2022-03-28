using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int? TrainerId { get; set; }
        public int? CourseCategoryId { get; set; }
        public double Price { get; set; }
        public int AvailableSeats { get; set; }
        public  TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public Trainer Trainer { get; set; }
        public IEnumerable<CourseTab> CourseTabs { get; set; }

    }
}
