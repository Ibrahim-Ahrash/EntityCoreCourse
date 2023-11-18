using EntityCoreCourse.Configuration;
using EntityCoreCourse.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoreCourse
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

            options.UseSqlServer(@"Data Source=DESKTOP-SVOUA9A\SQLEXPRESS;Initial Catalog=efCourseCode; Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogEntityTypeConfiuration().Configure(modelBuilder.Entity<Blog>());
        }

        public DbSet<Blog> Blogs { get; set; }
    }

}
