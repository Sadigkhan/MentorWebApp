using System.ComponentModel.DataAnnotations;

namespace MentorWebApp.Models
{
    public class CategoryOffering
    {
        public int Id { get; set; }
        public int PricingCategoryId { get; set; }
        public double Price { get; set; }
        [StringLength(255)]
        public string Offer1 { get; set; }
        [StringLength(255)]
        public string Offer2 { get; set; }
        [StringLength(255)]
        public string Offer3 { get; set; }
        [StringLength(255)]
        public string Offer4 { get; set; }
        [StringLength(255)]
        public string Offer5 { get; set; }
        public PricingCategory PricingCategory { get; set; }

    }
}
