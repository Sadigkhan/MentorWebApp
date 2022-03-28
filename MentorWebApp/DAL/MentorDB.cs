using MentorWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorWebApp.DAL
{
    public class MentorDB:DbContext
    {
        public MentorDB(DbContextOptions<MentorDB>options):base(options)
        {

        }
        public DbSet<CategoryOffering> CategoryOfferings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<CourseCategory>CourseCategories { get; set; }
        public DbSet<CourseTab>CourseTabs { get; set; }
        public DbSet<Event>Events { get; set; }
        public DbSet<PricingCategory>PricingCategories { get; set; }
        public DbSet<Trainer>Trainers { get; set; }
    }
}
