using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Data;
using Admin.Models;
using Admin.Models.Enums;

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
              return _context.Admissions != null ? 
                          View(await _context.Admissions.ToListAsync()) :
                          Problem("Entity set 'DatabaseContext.Admissions'  is null.");
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

        // GET: Admissions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admissions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FatherName,MotherName,Dob,Gender,ResAddress,PerAddress,AdmissionFor,University,EnrollmentNumber,Center,Stream,Field,MarkSecured,OutOf,ClassObtained,SportDetail,Status,CreatedAt,LastModifiedAt")] Admission admission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admission);

        }

        // GET: Admissions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Admissions == null)
            {
                return NotFound();
            }

            var admission = await _context.Admissions.FindAsync(id);
            if (admission == null)
            {
                return NotFound();
            }

            ViewBag.Gender = Enum.GetValues(typeof(Gender)).Cast<Gender>().Select(x => new SelectListItem
            {
                Value = ((int) x).ToString(),
                Text = x.ToString()
            });
            ViewBag.Status = Enum.GetValues(typeof(Status)).Cast<Status>().Select(x => new SelectListItem
            {
                Value = ((int) x).ToString(),
                Text = x.ToString()
            });
            
            return View(admission);
        }

        // POST: Admissions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FatherName,MotherName,Dob,Gender,ResAddress,PerAddress,AdmissionFor,University,EnrollmentNumber,Center,Stream,Field,MarkSecured,OutOf,ClassObtained,SportDetail,Status,CreatedAt,LastModifiedAt")] Admission admission)
        {
            if (id != admission.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmissionExists(admission.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(admission);
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

        // POST: Admissions/Delete/5
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
