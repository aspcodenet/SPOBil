using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bil.ViewModels
{
    public class BilIndexViewModel
    {
        public string SearchYear { get; set; }
        public string SearchManufacturer { get; set; }

        public BilIndexViewModel()
        {
            Cars = new List<BilListViewModel>();
        }
        public class BilListViewModel
        {
            public int Id { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }
        public List<BilListViewModel> Cars { get; set; }
    }
}