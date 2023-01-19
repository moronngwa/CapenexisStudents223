using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Data;

namespace CapenexisStudents223.Pages.Learners.Courses
{
    public class IndexModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public IndexModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Course != null)
            {
                Course = await _context.Course.ToListAsync();
            }
        }
    }
}
