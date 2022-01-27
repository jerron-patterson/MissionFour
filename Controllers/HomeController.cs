using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MissionFour.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MissionFour.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _conContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieContext x)
        {
            _logger = logger;
            _conContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult movieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult movieForm(movieEntry mer)
        {
            _conContext.Add(mer);
            _conContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
