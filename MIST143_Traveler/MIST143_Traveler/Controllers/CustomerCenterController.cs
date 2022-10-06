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
            return View();
        }

        public IActionResult Myfavorites()
        {
            return View();
        }
        public IActionResult Review()
        {
            return View();
        }
        public IActionResult Coupon()
        {
            return View();
        }
        public IActionResult Star()
        {
            return View();
        }

        public IActionResult 註冊Modal(/*Member p*/)
        {
        //    PlanetTravelContext db = new PlanetTravelContext();
        //    db.Members.Add(p);
        //    db.SaveChanges();

            return View();
        }
        public IActionResult 先隨便()
        {
            return PartialView("註冊Modal");
        }
    }
}

