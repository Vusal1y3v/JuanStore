using JuanStore.DAL;
using JuanStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JuanStore.ViewModels.Home;
using Microsoft.AspNetCore.Http;

namespace JuanStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s=>s.isMainSlider).ToListAsync(),
                Products = await _context.Products.ToListAsync()
            };
            

            return View(homeVM);
        }

        public async Task<IActionResult> CreatSession()
        {
            HttpContext.Session.SetString("basket", "hello");

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GetSession()
        {
            string basketcontent = HttpContext.Session.GetString("basket");

            return Content(basketcontent);
        }

    }
}
