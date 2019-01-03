using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bil.Controllers
{
    public class BilController : Controller
    {
        // GET: Bil
        public ActionResult Index()
        {
            var model = new ViewModels.BilIndexViewModel();
            var db = new Models.DBContext();

            model.Cars.AddRange( db.GetAll().Select(r=>new ViewModels.BilIndexViewModel.BilListViewModel
            {
                Manufacturer = r.Manufacturer,
                Model = r.Model,
                Year = r.Year,
                Id = r.Id
            }) );

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new Models.DBContext();
            var bil = db.Get(id);
            var model = new ViewModels.BilEditViewModel
            {
                Color = bil.Color,
                Manufacturer = bil.Manufacturer,
                Modell = bil.Model,
                //Price = bil.Price,
                Year = bil.Year,
                Id = bil.Id
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ViewModels.BilEditViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var db = new Models.DBContext();
            var bil = db.Get(model.Id);
            bil.Manufacturer = model.Manufacturer;
            bil.Model = model.Modell;
            //bil.Price = model.Price;
            bil.Year = model.Year;
            bil.Color = model.Color;

            return RedirectToAction("Index");
        }


        public ActionResult View(int id)
        {
            var db = new Models.DBContext();
            var bil = db.Get(id);
            var model = new ViewModels.BilViewViewModel
            {
                Color = bil.Color,
                Manufacturer = bil.Manufacturer,
                Model = bil.Model,
                Price = bil.Price,
                Year = bil.Year
            };
            
            return View(model);
        }
    }
}