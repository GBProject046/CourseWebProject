using CourseWebProject.Data;
using CourseWebProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseWebProject.Services
{
    public class SellerService
    {
        private readonly CourseWebProjectContext _context;

        public SellerService(CourseWebProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
