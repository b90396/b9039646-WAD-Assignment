using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using b9039646_WAD_Assignment.Models;

namespace b9039646_WAD_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OneLocation()
        {
            Random random = new Random();
            int max = _context.Locations.Count();
            int locationIndex = random.Next(max);
            Location[] LocationArray = _context.Locations.ToArray();

            return View(LocationArray[locationIndex]);
        }

        public IActionResult AllLocations()
        {
            List<Location> AllLocations = _context.Locations.ToList();

            return View(AllLocations); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
