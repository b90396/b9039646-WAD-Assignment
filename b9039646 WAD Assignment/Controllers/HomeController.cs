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
            List<Location> AllLocations = _context.Locations.ToList();

            return View(AllLocations);
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

        public IActionResult SortBy(string SortByParameter)
        {
            //List<Location> AllLocations = _context.Locations.ToList();

            var AllLocations = from l in _context.Locations select l;

            if (SortByParameter == "name")
            {
                AllLocations = AllLocations.OrderBy(l => l.Name);            
            }
            if (SortByParameter == "country")
            {
                AllLocations = AllLocations.OrderBy(l => l.Country);
            }
            if (SortByParameter == "continent")
            {
                AllLocations = AllLocations.OrderBy(l => l.Continent);
            }
            if (SortByParameter == "area")
            {
                AllLocations = AllLocations.OrderBy(l => l.Area);
            }


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
            FavouriteLocations list = new FavouriteLocations();
            FavouriteLocationReturnFrom model = new FavouriteLocationReturnFrom();

            if (_context.FavouriteLocations.Find(id) != null)
            {
                list = _context.FavouriteLocations.Find(id);
                model.location1 = _context.Locations.Find(list.locationCoordinates1);
            }
            else 
            {
                FavouriteLocations newList = new FavouriteLocations();
                newList.UserID = id;
                _context.FavouriteLocations.Add(newList);
                _context.SaveChanges();

                list = _context.FavouriteLocations.Find(id);
            }


            return View(model);
        }

        public IActionResult AddToFavourites(String GeographicalCoordinates)
        {
            var id = _userManager.GetUserId(User);
            if (_context.FavouriteLocations.Find(id).locationCoordinates1 == null)
            {
                _context.FavouriteLocations.Find(id).locationCoordinates1 = GeographicalCoordinates;
                _context.SaveChanges();
            }

            return RedirectToAction("FavouriteLocationsPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
