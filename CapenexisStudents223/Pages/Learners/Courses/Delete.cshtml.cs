﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Data;

namespace CapenexisStudents223.Pages.Learners.Courses
{
    public class DeleteModel : PageModel
    {
        private readonly CapenexisStudents223.Data.CapenexisStudents223Context _context;

        public DeleteModel(CapenexisStudents223.Data.CapenexisStudents223Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);

            if (course == null)
            {
                return NotFound();
            }
            else 
            {
                Course = course;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }
            var course = await _context.Course.FindAsync(id);

            if (course != null)
            {
                Course = course;
                _context.Course.Remove(Course);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
