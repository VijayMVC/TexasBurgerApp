using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TexasBurgerApp.Models;

namespace TexasBurgerApp.Controllers
{
    public class BurgerController : Controller
    {

        // GET: Burger
        public ActionResult Index(int? id)
        {
            if (!id.HasValue)
                id = 1;
            var viewModel = new IngTypeViewModel
            {
                ingridients = new IngMapper().SelectAllBread(),
                ingridientsMeats = new IngMapper().SelectAllMeat(),
                CurrentlySelected = new IngMapper().GetIngridient((int)id)
            };

            return View(viewModel);
        }

        public ActionResult AddBun(int id)
        {

            Session["Bun"] = id;
            return RedirectToAction("Index");
        }
    }
}