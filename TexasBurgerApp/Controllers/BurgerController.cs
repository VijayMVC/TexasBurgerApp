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


        public ActionResult AddBurger(string custName, int tableID, int bunID, int meatID, int cheeseID)
        {
            IngridientModel Bun = new IngMapper().GetIngridient(bunID);
            IngridientModel Meat = new IngMapper().GetIngridient(meatID);

            MenuModel Menu = new MenuModel
            {
                CustName = custName,
                TableID = tableID,
                Bun = Bun,
                Meat = Meat
            };

            if(cheeseID != 0)
            {
                Menu.Cheese = new IngMapper().GetIngridient(cheeseID);
            }

            MenuMapper mapper = new MenuMapper();
            mapper.CreateNewBurger(Menu);

            return this.RedirectToAction("Index", "Burger");

        }
    }
}