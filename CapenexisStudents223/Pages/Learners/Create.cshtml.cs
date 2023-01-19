using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapenexisStudents223.Data;

namespace CapenexisStudents223.Pages.Learnerslevel4
{
    public class CreateModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public CreateModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Learner Learnerlevel4 { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Learnerlevel4 == null || Learnerlevel4 == null)
            {
                return Page();
            }

            _context.Learnerlevel4.Add(Learnerlevel4);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
