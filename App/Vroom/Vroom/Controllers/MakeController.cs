using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vroom.Models;

namespace Vroom.Controllers
{
    public class MakeController : Controller
    {
        //make/bikes
        [Route("make")]
        [Route("make/bikes")]
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 0, Name = "Harley Davidson" };
            return View(make);
        }

        [Route("make/bikes/{year:int:length(4)}/{month:int:range(1,13)}")]
        public IActionResult ByYearMonth(int year, int month)
        {
            return Content(year + ";" + month);
        }
    }
}