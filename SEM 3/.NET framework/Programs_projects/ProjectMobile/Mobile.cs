using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobile
{
    public class Mobile
    {
        //Attributes :
        public string brand;
        public string model;
        public int battery_level;

        //Constructor
        public Mobile(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            this.battery_level = 0; //Setting intial battery_level a 0%
            
        }

        //Method to simulate making a call :
        public void makeCall(string phoneNumber)
        {
            Console.WriteLine(phoneNumber);
            Console.WriteLine("\nMaking a Call.....");
            useBattery(10); //10% Battery is consumed when making a call 
        }
        public void chargeBattery(int amount) {
            battery_level += amount;
            if (battery_level > 100) {
                battery_level = 100;
            }
            Console.WriteLine($"Battery charged to {battery_level}%");

        }
        public void useBattery(int amount)
        {
            battery_level -= amount;
            if (battery_level < 0) {
                battery_level = 0;
            }
            Console.WriteLine($"Battery level is now {battery_level}%");
        }

        //method to print mobile details
        public void printDetails()
        {
            Console.WriteLine($"Brand : {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Battery Level : {battery_level}%");
        }
    }

    


}
