using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bil.Models
{
    public class DBContext
    {
        protected static List<Bil> cars;

        public Bil Get(int id)
        {
            return GetAll().FirstOrDefault(r => r.Id == id);
        }

        public List<Bil> GetAll()
        {
            if(cars == null)
            {
                cars = new List<Bil>
                {
                    new Bil{ Id = 1, Color="Black",Manufacturer="Volvo",Model="XC60",Year=2014,Price=150000 },
                    new Bil{ Id = 2,Color="Red",Manufacturer="Ford",Model="Focus",Year=2016,Price=150000 },
                    new Bil{ Id = 3,Color="Green",Manufacturer="Volvo",Model="XC90",Year=2017,Price=650000 },
                    new Bil{ Id = 4,Color="Yellow",Manufacturer="Ford",Model="Mustang",Year=1968,Price=150000 },
                    new Bil{ Id = 5,Color="Black",Manufacturer="Renault",Model="Clio",Year=2005,Price=15000 },
                };
            }
            return cars;
        }
    }
}