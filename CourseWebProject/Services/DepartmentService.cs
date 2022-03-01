using CourseWebProject.Data;
using CourseWebProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseWebProject.Services
{
    public class DepartmentService
    {
        private readonly CourseWebProjectContext _context;

        public DepartmentService(CourseWebProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }


    }
}
