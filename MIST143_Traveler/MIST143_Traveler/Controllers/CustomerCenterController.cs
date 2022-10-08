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

        public IActionResult ProductManage()//在家測試123456123312312321
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

