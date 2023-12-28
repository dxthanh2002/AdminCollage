using Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;
using Admin.Models;

namespace Admin.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        {
        }


        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<PreviousEducation>? PreviousEducations { get; set; }
        public DbSet<Admission>? Admissions { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Faculty>? Faculties { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<SectionData>? Sections { get; set; }
        public DbSet<PostImage>? PostImages { get; set; }
        public DbSet<Models.Image>? Images { get; set; }
        public DbSet<Facility>? Facilities { get; set; }
        public DbSet<Feedback>? Feedbacks { get; set; }
        public DbSet<ContactUs>? ContactUs { get; set; }
    }
}
