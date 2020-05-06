using Microsoft.EntityFrameworkCore;
using Core.Entities.CourseAggregate;
using Core.Entities.LessonAggregate;
using System.Reflection;

namespace Infrastructure.Data
{
    public class LearnContext : DbContext
    {
        public LearnContext(DbContextOptions<LearnContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TechLogo> TechLogos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BuyCourse> BuyCourse { get; set; }

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Complete> Completes { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TypeTask> TypeTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
