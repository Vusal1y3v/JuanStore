using JuanStore.DAL;
using JuanStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuanStore.Areas.AdminPanel.ViewModels;

namespace JuanStore.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products
                .Where(p=>p.IsDeleted == false)
                .Include(p => p.Category)
                .ToListAsync();

            return View(products);
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            
            if (product is null) return NotFound();
            
            product.IsDeleted = true;
            
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductPostVM productPostVM)
        {
            var product = new Product();

            product.Id = productPostVM.Id;

            product.Name = productPostVM.Name;

            product.Count = productPostVM.Count;

            product.Price = productPostVM.Price;

            product.CategoryId = productPostVM.CategoryId;

            product.IsTopSeller = productPostVM.IsTopSeller;

            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
