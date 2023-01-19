using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Data;

namespace CapenexisStudents223.Pages.Learnerslevel4
{
    public class EditModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public EditModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Learner Learnerlevel4 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Learnerlevel4 == null)
            {
                return NotFound();
            }

            var learnerlevel4 =  await _context.Learnerlevel4.FirstOrDefaultAsync(m => m.ID == id);
            if (learnerlevel4 == null)
            {
                return NotFound();
            }
            Learnerlevel4 = learnerlevel4;
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

            _context.Attach(Learnerlevel4).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Learnerlevel4Exists(Learnerlevel4.ID))
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

        private bool Learnerlevel4Exists(int id)
        {
          return (_context.Learnerlevel4?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
