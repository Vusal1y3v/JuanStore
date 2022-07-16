using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuanStore.Areas.AdminPanel.ViewModels;
using JuanStore.DAL;
using JuanStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanStore.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        
        
        public async Task<IActionResult> Index()
        {
            List<Category> category = await _context.Categories
                .ToListAsync();

            return View(category);
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.Where(p => p.Id == id).FirstOrDefaultAsync();
            
            if (category is null) return NotFound();

            _context.Categories.Remove(category);
            
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(CategoryPostVM categoryPostVm)
        {
            var category = new Category();

            category.Name = categoryPostVm.Name;

            _context.Categories.Add(category);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}