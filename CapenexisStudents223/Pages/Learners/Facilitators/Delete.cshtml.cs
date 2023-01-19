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
    public class DeleteModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public DeleteModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Facilittator == null)
            {
                return NotFound();
            }
            var facilittator = await _context.Facilittator.FindAsync(id);

            if (facilittator != null)
            {
                Facilittator = facilittator;
                _context.Facilittator.Remove(Facilittator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
