using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisStudents223.Pages.Learnerslevel4;
using CapenexisStudents223.Pages.Learnerslevel4.Facilitators;
using CapenexisStudents223.Pages.Learners.Courses;

namespace CapenexisStudents223.Data
{
    public class CapenexisStudents223Context : DbContext
    {
        public CapenexisStudents223Context (DbContextOptions<CapenexisStudents223Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisStudents223.Pages.Learnerslevel4.Learner> Learnerlevel4 { get; set; } = default!;

        public DbSet<CapenexisStudents223.Pages.Learnerslevel4.Facilitators.Facilittator> Facilittator { get; set; } = default!;

        public DbSet<CapenexisStudents223.Pages.Learners.Courses.Course> Course { get; set; } = default!;
    }
}
