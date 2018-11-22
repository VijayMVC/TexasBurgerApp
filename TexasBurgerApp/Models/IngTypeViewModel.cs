using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TexasBurgerApp.Models
{
    public class IngTypeViewModel
    {
        public List<IngridientModel> ingridients { get; set; }
        public List<IngridientModel> ingridientsMeats { get; set; }
        public List<IngridientModel> ingridientsCheese { get; set; }
        public List<IngridientModel> ingridientsGreen { get; set; }
        public List<IngridientModel> ingridientsDressing { get; set; }
        public IngridientModel CurrentlySelected{ get; set; }

    }
}