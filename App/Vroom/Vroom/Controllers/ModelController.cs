using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vroom.Models;
using Vroom.Models.ViewModels;

namespace Vroom.Controllers
{
    [Authorize(Roles = ("Admin,Executive"))]
    public class ModelController : Controller
    {
        private readonly VroomDbContext _VDbContext;

        [BindProperty]
        public ModelViewModel ModelVM { get; set; }

        public ModelController(VroomDbContext VDbContext)
        {
            _VDbContext = VDbContext;

            ModelVM = new ModelViewModel()
            {
                Makes = _VDbContext.Makes.ToList(),
                Model = new Models.Model()
            }; 
        }
        public IActionResult Index()
        {
            var model = _VDbContext.Models.Include(m => m.make);
            return View(model);
        }


        //HTTP GET
        public IActionResult Create()
        {
            return View(ModelVM);
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _VDbContext.Models.Add(ModelVM.Model);
            _VDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }   

        //Http Get
        public IActionResult Edit(int id)
        {
            ModelVM.Model = _VDbContext.Models.Include(m => m.make).SingleOrDefault(m => m.Id == id);
            if(ModelVM.Model == null)
            {
                return NotFound();
            }
            return View(ModelVM);
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _VDbContext.Update(ModelVM.Model);
            _VDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var model = _VDbContext.Models.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            _VDbContext.Models.Remove(model);
            _VDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}