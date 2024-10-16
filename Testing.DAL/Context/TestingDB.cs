using Microsoft.EntityFrameworkCore;
using Testing.DAL.Entityes;

namespace Testing.DAL.Context
{
    public class TestingDB : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Questions> Questions { get; set; }

        public DbSet<Answers> Answers { get; set; }

        public DbSet<Person> Persons { get; set; }

        public TestingDB(DbContextOptions<TestingDB>  options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>()
                .Property(b => b.TimeTesting)
                .HasDefaultValue(30);
        }
    }
}
