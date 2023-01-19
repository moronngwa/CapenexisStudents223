using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Data;
using CapenexisStudents223.Pages.Learnerslevel4.Facilitators;

namespace CapenexisStudents223.Pages.Learners.Facilitators
{
    public class EditModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public EditModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
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

            var facilittator =  await _context.Facilittator.FirstOrDefaultAsync(m => m.ID == id);
            if (facilittator == null)
            {
                return NotFound();
            }
            Facilittator = facilittator;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Facilittator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacilittatorExists(Facilittator.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FacilittatorExists(int id)
        {
          return (_context.Facilittator?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
