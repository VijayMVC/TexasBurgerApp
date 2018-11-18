using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TexasBurgerApp.Models
{
    public class MenuModel
    {
        public IngridientModel Bun { get; set; } = null;
        public IngridientModel[] Meat { get; set; }//Max 2
        public IngridientModel[] Greens { get; set; } //Max 3
        public IngridientModel[] Dressing { get; set; } //Max 3
        public IngridientModel Drink { get; set; }
    }
}