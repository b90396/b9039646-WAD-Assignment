using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using b9039646_WAD_Assignment.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace b9039646_WAD_Assignment.Controllers
{
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
            //List<Track> model = _context.Tracks.ToList();
            return View(); //model
        }

        [HttpGet]
        public IActionResult AddTrack()
        {
            return View();
        }
    }
}
