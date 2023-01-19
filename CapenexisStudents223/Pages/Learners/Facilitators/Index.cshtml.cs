using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Data;
using CapenexisStudents223.Pages.Learnerslevel4.Facilitators;

namespace CapenexisStudents223.Pages.Learners.Facilitators
{
    public class IndexModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public IndexModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        public IList<Facilittator> Facilittator { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Facilittator != null)
            {
                Facilittator = await _context.Facilittator.ToListAsync();
            }
        }
    }
}
