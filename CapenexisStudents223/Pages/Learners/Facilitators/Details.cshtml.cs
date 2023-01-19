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
    public class DetailsModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public DetailsModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

      public Facilittator Facilittator { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Facilittator == null)
            {
                return NotFound();
            }

            var facilittator = await _context.Facilittator.FirstOrDefaultAsync(m => m.ID == id);
            if (facilittator == null)
            {
                return NotFound();
            }
            else 
            {
                Facilittator = facilittator;
            }
            return Page();
        }
    }
}
