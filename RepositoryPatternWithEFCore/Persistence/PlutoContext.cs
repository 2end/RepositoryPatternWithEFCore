using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithEFCore.Core.Domain;
using RepositoryPatternWithEFCore.Persistence.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternWithEFCore.Persistence
{
    public class PlutoContext: DbContext
    {
        public PlutoContext()
        {
            this.Database.EnsureCreated();
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=repositorydb;Trusted_Connection=True;");
        }
    }       
}
