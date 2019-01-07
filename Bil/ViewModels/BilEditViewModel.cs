using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bil.ViewModels
{
    public class BilEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        public string Modell { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        //public decimal Price { get; set; }

    }

    public class BilCreateViewModel
    {
        [Required]
        public string Manufacturer { get; set; }

        public string Modell { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        //public decimal Price { get; set; }

    }

}