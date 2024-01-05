using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin.Data;
using Microsoft.Extensions.Options;

namespace Admin.Controllers
{
    public class AdmissionsController : Controller
    {
        private readonly DatabaseContext _context;
        
        public AdmissionsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Admissions
        public async Task<IActionResult> Index()
        {
            return _context.Admissions != null
                ? View(await _context.Admissions.ToListAsync())
                : Problem("Entity set 'DatabaseContext.Admissions'  is null.");
        }

        // GET: Admissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Admissions == null)
            {
                return NotFound();
            }

            var admission = await _context.Admissions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admission == null)
            {
                return NotFound();
            }

            return View(admission);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Admissions == null)
            {
                return NotFound();
            }

            var admission = await _context.Admissions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admission == null)
            {
                return NotFound();
            }

            return View(admission);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Admissions == null)
            {
                return Problem("Entity set 'DatabaseContext.Admissions'  is null.");
            }

            var admission = await _context.Admissions.FindAsync(id);
            if (admission != null)
            {
                _context.Admissions.Remove(admission);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmissionExists(int id)
        {
            return (_context.Admissions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}