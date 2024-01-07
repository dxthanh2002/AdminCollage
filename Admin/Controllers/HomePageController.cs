using Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin.Controllers;

public class HomePageController : Controller
{
    private readonly DatabaseContext _context;
    
    public HomePageController(DatabaseContext context)
    {
        _context = context;
    }
    
    // GET: Faculties
    public async Task<IActionResult> Index()
    {
        var banner = await _context.Images?.Where(x => x.Page == "home" && x.Section == "banner").ToListAsync()!;
        return View(banner);
    }
    
    public IActionResult Create()
    {
        return View();
    }
}