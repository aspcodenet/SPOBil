using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bil.ViewModels
{
    public class BilEditViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Modell { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        //public decimal Price { get; set; }

    }
}