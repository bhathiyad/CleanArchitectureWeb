using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<StudentCourse>()
            //    .HasKey(x => new { x.StudentId, x.CourseId });

            //modelBuilder.Entity<Student>()
            //    .HasOne(x => x.)
            //    .WithMany(y => y.)
            //    .HasForeignKey(y => y.JobId);

            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne(x => x.Course)
            //    .WithMany(y => y.Students)
            //    .HasForeignKey(y => y.ClientId);

            modelBuilder.Entity<StudentCourse>().HasKey(t => new { t.StudentId, t.CourseId });

            modelBuilder.Entity<StudentCourse>()
              .HasOne(pt => pt.Student)
              .WithMany(p => p.Courses)
              .HasForeignKey(pt => pt.StudentId);

            modelBuilder.Entity<StudentCourse>()
              .HasOne(pt => pt.Course)
              .WithMany(t => t.Students)
              .HasForeignKey(pt => pt.CourseId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
