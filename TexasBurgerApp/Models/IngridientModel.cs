using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TexasBurgerApp.Models
{
    public class IngridientModel
    {
        public int ID { get; set; }
        public string IngName { get; set; }
        public int Cost { get; set; }
        public TypeModel Type { get; set; }


    }
}