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


        //Http Get Method
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                _VDbContext.Add(make);
                _VDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _VDbContext.Makes.Find(id);
            if(make == null)
            {
                return NotFound();
            }
            _VDbContext.Makes.Remove(make);
            _VDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}