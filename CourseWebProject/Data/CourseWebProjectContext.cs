using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseWebProject.Models;

namespace CourseWebProject.Data
{
    public class CourseWebProjectContext : DbContext
    {
        public CourseWebProjectContext (DbContextOptions<CourseWebProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CourseWebProject.Models.Department> Department { get; set; }
        public DbSet<CourseWebProject.Models.Seller> Seller { get; set; }
        public DbSet<CourseWebProject.Models.SalesRecord> SalesRecord { get; set; }
    }
}
