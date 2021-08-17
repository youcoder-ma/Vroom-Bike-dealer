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
            var model = _VDbContext.Models.Include(m => m.Make);
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
    }
}