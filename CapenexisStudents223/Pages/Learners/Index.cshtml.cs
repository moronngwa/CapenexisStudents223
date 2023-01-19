using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Data;

namespace CapenexisStudents223.Pages.Learnerslevel4
{
    public class IndexModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public IndexModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        public IList<Learner> Learnerlevel4 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Learnerlevel4 != null)
            {
                Learnerlevel4 = await _context.Learnerlevel4.ToListAsync();
            }
        }
    }
}
