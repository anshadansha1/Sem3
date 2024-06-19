using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondab
{
   public abstract class Mobile
    {
        protected string brand;
        protected string model;
        protected int battery_level;

        protected Mobile(string brand,string model,int battery_level) { 
            this.brand = brand;
            this.model = model;
            this.battery_level = battery_level;
        }
        public abstract void StartDevice();
        public abstract void   UseDevice();
        public void ShowDetails()
        {
            Console.WriteLine($"Brand : {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Battery Level : {battery_level}%");
        }
    }
}
