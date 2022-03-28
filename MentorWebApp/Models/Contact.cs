using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Location { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
