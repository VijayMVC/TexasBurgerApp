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
                ingridientsGreen = new IngMapper().SelectAllGreen(),
                ingridientsDressing = new IngMapper().SelectAllDressing(),
                CurrentlySelected = new IngMapper().GetIngridient((int)id)
            };

            return View(viewModel);
        }


        public ActionResult AddBurger(string custName, int tableID, int bunID, int meatID, int cheeseID, int greenID, int dressingID)
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

            if (greenID != 0)
            {
                Menu.Green = new IngMapper().GetIngridient(greenID);
            }

            if (dressingID != 0)
            {
                Menu.Dressing = new IngMapper().GetIngridient(dressingID);
            }

            IngMapper mapper = new IngMapper();
            mapper.CreateNewBurger(Menu);

            return this.RedirectToAction("Index", "Burger");

        }
    }
}