using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Cate = _conContext.categ.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult movieForm(movieEntry mer)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Cate = _conContext.categ.ToList();
                _conContext.Add(mer);
                _conContext.SaveChanges();
                return View();
            }
            else
            {
                ViewBag.Cate = _conContext.categ.ToList();
                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult movieTable()
        {
            var applications = _conContext.entry.Include(x => x.category).ToList();
            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Cate = _conContext.categ.ToList();
            var ent = _conContext.entry.Single(x => x.movieID == id);
            return View("movieForm", ent);
        }
        [HttpPost]
        public IActionResult Edit(movieEntry ed)
        {
            _conContext.Update(ed);
            _conContext.SaveChanges();
            return RedirectToAction("movieTable");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var ent = _conContext.entry.Single(x => x.movieID == id);
            return View(ent);
        }
        [HttpPost]
        public IActionResult Delete(movieEntry ed)
        {
            _conContext.Remove(ed);
            _conContext.SaveChanges();
            return RedirectToAction("movieTable");
        }
    }
}
