using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vroom.Models;
using Vroom.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting.Internal;

namespace Vroom.Controllers
{
    public class BikeController : Controller
    {
        private readonly VroomDbContext _VDbContext;
        private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public BikeViewModel BikeVM { get; set; }

        public BikeController(VroomDbContext VDbContext, HostingEnvironment hostingEnvironment)
        {
            _VDbContext = VDbContext;
            _hostingEnvironment = hostingEnvironment;

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
                BikeVM.Makes = _VDbContext.Makes.ToList();
                BikeVM.Models = _VDbContext.Models.ToList();
                return View(BikeVM);
            }
            _VDbContext.Bikes.Add(BikeVM.Bike);
            _VDbContext.SaveChanges();

            /////////////////////////
            /// Save Bike Logic//////
            ////////////////////////

            //Get bike Id we have saved in db
            var BikeId = BikeVM.Bike.Id;

            //Get wwwrootPath to save the file on server 
            string wwwrootPath = _hostingEnvironment.WebRootPath;

            //Get the uploaded files 
            var files = HttpContext.Request.Form.Files;

            //Get the reference of DbSet for the bike we just saved in database 
            var SavedBike = _VDbContext.Bikes.Find(BikeId);

            //Upload the files on server and save the image path uploaded by user if any 

            if (files.Count != 0)
            {
                var ImagePath = @"images\bike\";
                var Extension = Path.GetExtension(files[0].FileName);
                var RelativeImagePath = ImagePath + BikeId + Extension;
                var AbsImagePath = Path.Combine(wwwrootPath, RelativeImagePath);

                //Upload file on server
                using (var fileStream = new FileStream(AbsImagePath, FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                //Set the image path on database 
                SavedBike.ImagePath = RelativeImagePath;
                _VDbContext.SaveChanges();
            }
            /////////////////////////

            



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

        public IActionResult Delete(int id)
        {
            var bike = _VDbContext.Bikes.Find(id);
            if (bike == null)
            {
                return NotFound();
            }
            _VDbContext.Bikes.Remove(bike);
            _VDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}