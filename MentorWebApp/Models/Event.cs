using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Startdate { get; set; }
        [StringLength(1000)]
        public string Context { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
    }
}
