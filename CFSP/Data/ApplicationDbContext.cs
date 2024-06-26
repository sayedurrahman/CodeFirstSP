using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CFSP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var s = new List<Student> {
                        new Student()
                        {
                            ID = 1,
                            FirstMidName = "Andrew",
                            LastName = "Peters",
                            EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                        },
                        new Student()
                        {
                            ID = 2,
                            FirstMidName = "Brice",
                            LastName = "Lambson",
                            EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                        },
                        new Student()
                        {
                            ID = 3,
                            FirstMidName = "Rowan",
                            LastName = "Miller",
                            EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                        }
            };

            modelBuilder.Entity<Student>().HasData(s);
        }

        public override EntityEntry Update(object entity)
        {
            return base.Update(entity);
        }
    }
}
