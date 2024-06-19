using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobile
{
    interface ICamera
    {
        void TakePhoto();
    }
    interface IGps
    {
        void GetLocation();
    }
    public class Android : Mobile, ICamera, IGps
    {
        public void TakePhoto()
        {
            Console.WriteLine("Pic ");   
        }
        public void GetLocation()
        {
            Console.WriteLine("Get loc");
        }
        public Android(string brand,string model) : base(brand, model)
        {

        }
        public void installApp(string appName)
        {
            if (battery_level > 20) {
                Console.WriteLine($"Installing {appName} app....");
                useBattery(5);
            }
            else
            {
                Console.WriteLine("Battery is not suffiecient to Install an App.Please charge your phone ");
            }
        }
    }
}
