using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Testing.DAL.Entityes;
using Testing.DAL.Entityes.Base;

namespace Testing.DAL.Context
{
    public abstract class TestingDB : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Questions> Ques { get; set; }

        public DbSet<Answers> Answers { get; set; }

        public DbSet<Person> Persons { get; set; }

        public TestingDB(DbContextOptions<TestingDB>  options) : base(options) { }
    }
}
