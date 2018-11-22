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
        //Index page. The landing page of the app
        public ActionResult Index(int? id)
        {
            if (!id.HasValue)
                id = 1;

            //Creates a new viewModel based on the needed models in the View
            var viewModel = new IngTypeViewModel
            {
                ingridients = new IngMapper().SelectAllBread(),
                ingridientsMeats = new IngMapper().SelectAllMeat(),
                ingridientsCheese = new IngMapper().SelectAllCheese(),
                CurrentlySelected = new IngMapper().GetIngridient((int)id)
            };

            //Returns the view with the model
            return View(viewModel);
        }

        //Link to create a new burger
        public ActionResult AddBurger(string custName, int tableID, int bunID, int meatID, int cheeseID)
        {
            //Gets the ingridient Model based on the ID given in the argument
            IngridientModel Bun = new IngMapper().GetIngridient(bunID);
            IngridientModel Meat = new IngMapper().GetIngridient(meatID);

            //Instanciates a new Menu Object with the ingridient objects.
            MenuModel Menu = new MenuModel
            {
                CustName = custName,
                TableID = tableID,
                Bun = Bun,
                Meat = Meat
            };

            //Check if a optional ingridient has been chosen.
            if(cheeseID != 0)
            {
                Menu.Cheese = new IngMapper().GetIngridient(cheeseID);
            }

            //Initializes the Mapper object for the MenuModel
            MenuMapper mapper = new MenuMapper();
            mapper.CreateNewBurger(Menu);

            //Redirects to the start page
            return this.RedirectToAction("Index", "Burger");

        }
    }
}