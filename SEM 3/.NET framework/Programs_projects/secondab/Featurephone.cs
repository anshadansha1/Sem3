using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondab
{
    public class Featurephone : Mobile
    {
        int buttonCount;
        public Featurephone(string brand, string model, int battery_level, int buttonCount) : base(brand, model, battery_level)
        {
            this.buttonCount = buttonCount;
        }
        public override void StartDevice()
        {
            Console.WriteLine("featurephone device start");
        }
        public override void UseDevice()
        {
            Console.WriteLine(" featurephone use device");
        }
        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Button count:{buttonCount}");
        }


    }
}
