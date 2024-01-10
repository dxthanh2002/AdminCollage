using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin.Data;
using Admin.Models;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace Admin.Controllers
{
    public class AdmissionsController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        
        public AdmissionsController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Admissions
        public async Task<IActionResult> Index()
        {
            var admission = await _context.Admissions?.ToListAsync()!;
            var department = await _context.Departments?.ToListAsync()!;
            var admissionModel = _mapper.Map<List<AdmissionResponse>>(admission);
            foreach (var t in department)
            {
                foreach (var t1 in admissionModel.Where(t1 => t.Id == t1.AdmissionFor))
                {
                    t1.Department = t.Name;
                }
            }
            ViewBag.Departments = department;
            ViewBag.Status = new List<string> { "PENDING", "APPROVED", "REJECTED" };
            
            return View(admissionModel.OrderByDescending(x => x.CreatedAt));
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
            var admissionModel = _mapper.Map<AdmissionResponse>(admission);
            var department = await _context.Departments?.FirstOrDefaultAsync(item => item.Id == admissionModel.AdmissionFor)!;
            admissionModel.Department = department?.Name!;
            return View(admissionModel);
        }
        
        // GET: Admissions/Delete/5
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