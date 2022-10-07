using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIST143_Traveler.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult PayData()
        {
            //高歌離席
            return View();
        }
        public IActionResult PayCheckout()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}
