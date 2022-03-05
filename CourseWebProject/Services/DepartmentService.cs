using CourseWebProject.Data;
using CourseWebProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseWebProject.Services
{
    public class DepartmentService
    {
        private readonly CourseWebProjectContext _context;

        public DepartmentService(CourseWebProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }


    }
}
