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
    public class IndexModel : PageModel
    {
        private readonly Admin.Data.DatabaseContext _context;

        public IndexModel(Admin.Data.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Faculty> Faculty { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Faculties != null)
            {
                Faculty = await _context.Faculties
                .Include(f => f.Department).ToListAsync();
            }
        }
    }
}
