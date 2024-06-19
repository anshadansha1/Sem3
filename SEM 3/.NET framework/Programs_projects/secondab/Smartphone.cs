using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondab
{
    public class Smartphone : Mobile
    {
        string osVersion;
        public Smartphone(string brand, string model, int battery_level, string osVersion) : base(brand, model, battery_level)
        {
            this.osVersion = osVersion;
        }
        
        public override void StartDevice()
        {
            Console.WriteLine("smartphone device start");
        }
        public override void UseDevice()
        {
            Console.WriteLine("smart phone use device");
        }
        public  void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"os version:{osVersion}");
        }
    }
}
