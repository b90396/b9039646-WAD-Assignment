using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using b9039646_WAD_Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace b9039646_WAD_Assignment.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CmsController : Controller
    {

        private readonly ILogger<CmsController> _logger;

        private readonly ApplicationDbContext _context;

        
        public CmsController(ILogger<CmsController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }


        public IActionResult Index()
        {
            List<Location> model = _context.Locations.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLocation(locationForm model)
        {
            if (ModelState.IsValid)
            {
                Location newLocation = new Location
                {
                    Name = model.Name,
                    Description = model.Description,
                    Justification = model.Justification,
                    Date = model.Date,
                    Danger = model.Danger,
                    Longitude = model.Longitude,
                    Latitude = model.Latitude,
                    Area = model.Area,
                    Category = model.Category,
                    Country = model.Country,
                    Continent = model.Continent,
                    GeographicalCoordinates = model.GeographicalCoordinates
                };

                _context.Add(newLocation);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditLocation(String GeographicalCoordinates)
        {
            Location model = _context.Locations.Find(GeographicalCoordinates);
            locationForm formModel = new locationForm
            {
                Name = model.Name,
                Description = model.Description,
                Justification = model.Justification,
                Date = model.Date,
                Danger = model.Danger,
                Longitude = model.Longitude,
                Latitude = model.Latitude,
                Area = model.Area,
                Category = model.Category,
                Country = model.Country,
                Continent = model.Continent,
                GeographicalCoordinates = model.GeographicalCoordinates
            };
            return View(formModel);
        }

        [HttpPost]
        public IActionResult EditLocation(locationForm model)
        {
            if (ModelState.IsValid)
            {
                Location editedLocation = new Location
                {
                    Name = model.Name,
                    Description = model.Description,
                    Justification = model.Justification,
                    Date = model.Date,
                    Danger = model.Danger,
                    Longitude = model.Longitude,
                    Latitude = model.Latitude,
                    Area = model.Area,
                    Category = model.Category,
                    Country = model.Country,
                    Continent = model.Continent,
                    GeographicalCoordinates = model.GeographicalCoordinates
                };

                _context.Locations.Update(editedLocation);

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteLocation(String GeographicalCoordinates)
        {
            Location model = _context.Locations.Find(GeographicalCoordinates);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteLocation(Location model)
        {
            _context.Locations.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
