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
        private readonly VroomDbContext _VDbContext;

        public MakeController(VroomDbContext VDbContext)
        {
            _VDbContext = VDbContext;
        }

        public IActionResult Index()
        {
            return View(_VDbContext.Makes.ToList());
        }
    }
}