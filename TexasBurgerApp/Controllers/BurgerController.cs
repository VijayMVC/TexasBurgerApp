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
                ingridientsCheese = new IngMapper().SelectAllCheese(),
                CurrentlySelected = new IngMapper().GetIngridient((int)id)
            };

            return View(viewModel);
        }

        public ActionResult AddBurger(int bunID, int meatID, int? cheeseID)
        {

            return Content("Test Data " + bunID);
        }
    }
}