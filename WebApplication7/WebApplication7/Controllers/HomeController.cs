using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.DAL;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;}

        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();

            return View(sliders);
        }
    }
}
