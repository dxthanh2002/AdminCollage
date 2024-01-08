using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Admin.Data;
using Admin.Models;

namespace Admin.Views.Faculties
{
    public class DetailsModel : PageModel
    {
        private readonly Admin.Data.DatabaseContext _context;

        public DetailsModel(Admin.Data.DatabaseContext context)
        {
            _context = context;
        }

      public Faculty Faculty { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Faculties == null)
            {
                return NotFound();
            }

            var faculty = await _context.Faculties.FirstOrDefaultAsync(m => m.Id == id);
            if (faculty == null)
            {
                return NotFound();
            }
            else 
            {
                Faculty = faculty;
            }
            return Page();
        }
    }
}
