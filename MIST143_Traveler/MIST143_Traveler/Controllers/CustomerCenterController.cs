using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIST143_Traveler.Controllers
{
    public class CustomerCenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            //PlanetTravelContext db = new PlanetTravelContext();

            return View();
        }

        public IActionResult ProductManage()
        {
            return PartialView();
        }

        public IActionResult Myfavorites()
        {
            return PartialView();
        }
        public IActionResult Review()
        {
            return PartialView();
        }
        public IActionResult Coupon()
        {
            return PartialView();
        }
        public IActionResult Star()
        {
            return PartialView();
        }

        public IActionResult CustomerInfo()
        {
            return PartialView();
        }

        public IActionResult Createmember()
        {

            return View();
        }
        public IActionResult LoginModal()
        {
            return View();
        }

    }
}

