using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MIST143_Traveler.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MIST143_Traveler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
<<<<<<< HEAD
            return View();//branch test //蒜泥白肉
=======
<<<<<<< HEAD
            return View();//branch test//蒜泥白肉好好吃萬歲
=======
            return View();//branch test//蒜泥白肉好好吃600元便當店
>>>>>>> master

>>>>>>> 09933be649568a603707c98d68d5f3c16bbc74a8
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactCenter()
        {
            return View(); //miyo的小天地
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
