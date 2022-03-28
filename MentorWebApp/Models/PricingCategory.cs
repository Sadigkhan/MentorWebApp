using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class PricingCategory
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<CategoryOffering> CategoryOfferings { get; set; }
    }
}
