using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vroom.Models;
using Vroom.Models.ViewModels;

namespace Vroom.Controllers
{
    public class BikeController : Controller
    {
        private readonly VroomDbContext _VDbContext;

        [BindProperty]
        public BikeViewModel BikeVM { get; set; }

        public BikeController(VroomDbContext VDbContext)
        {
            _VDbContext = VDbContext;

            BikeVM = new BikeViewModel()
            {
                Makes = _VDbContext.Makes.ToList(),
                Models = _VDbContext.Models.ToList(),
                Bike = new Models.Bike()
            };
        }
        public IActionResult Index()
        {
            var Bikes = _VDbContext.Bikes.Include(m => m.Make).Include(m => m.Model);
            return View(Bikes.ToList());
        }


        //HTTP GET
        public IActionResult Create()
        {
            return View(BikeVM);
        }


        //Post Method
        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(BikeVM);
            }
            _VDbContext.Bikes.Add(BikeVM.Bike);
            _VDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //Http Get
        //public IActionResult Edit(int id)
        //{
        //    ModelVM.Model = _VDbContext.Models.Include(m => m.make).SingleOrDefault(m => m.Id == id);
        //    if (ModelVM.Model == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(ModelVM);
        //}

        //[HttpPost, ActionName("Edit")]
        //public IActionResult EditPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(ModelVM);
        //    }
        //    _VDbContext.Update(ModelVM.Model);
        //    _VDbContext.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}

        //public IActionResult Delete(int id)
        //{
        //    var model = _VDbContext.Models.Find(id);
        //    if (model == null)
        //    {
        //        return NotFound();
        //    }
        //    _VDbContext.Models.Remove(model);
        //    _VDbContext.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}