using JuanStore.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using JuanStore.Models;
using System.Threading.Tasks;
using JuanStore.ViewModels.Prodcut;

namespace JuanStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<IActionResult> Index(int pageIndex = 1)
        {
            List<Product> products = await _context
                .Products
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            ViewBag.ProductCount = (int)Math.Ceiling((decimal)products.Count / 12);

            ViewBag.PageIndex = pageIndex;

            ProductVM productVM = new ProductVM
            {
                Categories = await _context.Categories.Include(m=>m.Products).ToListAsync(),
                Products = products.OrderByDescending(p => p.Id).Skip((pageIndex - 1) * 12).Take(12).ToList()

            };
            

            return View(productVM);
        }
        
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product is null) return BadRequest();
            
            return View(product);
        }

        

    }
}
