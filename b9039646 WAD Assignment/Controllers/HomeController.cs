using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using b9039646_WAD_Assignment.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace b9039646_WAD_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<User> manager)
        {
            _logger = logger;
            _context = context;
            _userManager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RandomLocation()
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

        public IActionResult OneLocation(String GeographicalCoordinates)
        {
            Location model = _context.Locations.Find(GeographicalCoordinates);
            return View(model);
        
        }

        public IActionResult FavouriteLocationsPage() 
        {
            var id = _userManager.GetUserId(User);
            FavouriteLocations model = null;

            if (_context.FavouriteLocations.Find(id) != null)
            {
                model = _context.FavouriteLocations.Find(id);
            }
            else 
            {
                FavouriteLocations newList = new FavouriteLocations();
                newList.UserID = id;
                _context.FavouriteLocations.Add(newList);
                _context.SaveChanges();

                model = _context.FavouriteLocations.Find(id);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
