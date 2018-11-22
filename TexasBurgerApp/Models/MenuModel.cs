using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TexasBurgerApp.Models
{
    public class MenuModel
    {
        public int TableID { get; set; }
        public string CustName { get; set; }
        public IngridientModel Bun { get; set; }
        public IngridientModel Meat { get; set; }//Max 2
        public IngridientModel Cheese { get; set; } = null;
        public IngridientModel Green { get; set; } = null;
        public IngridientModel Dressing { get; set; } = null;
    }
}