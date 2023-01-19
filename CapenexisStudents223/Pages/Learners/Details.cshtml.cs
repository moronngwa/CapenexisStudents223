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
    public class DetailsModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public DetailsModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

      public Learner Learnerlevel4 { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Learnerlevel4 == null)
            {
                return NotFound();
            }

            var learnerlevel4 = await _context.Learnerlevel4.FirstOrDefaultAsync(m => m.ID == id);
            if (learnerlevel4 == null)
            {
                return NotFound();
            }
            else 
            {
                Learnerlevel4 = learnerlevel4;
            }
            return Page();
        }
    }
}
