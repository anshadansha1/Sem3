namespace ProjectMobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Mobile myPhone = new Mobile("Apple", "Iphone 15");
            myPhone.chargeBattery(50);
            myPhone.makeCall("8157847663");
            myPhone.useBattery(20);
            myPhone.printDetails();

            Android android1 = new Android("Samsung", "S21 FE");
            android1.chargeBattery(50);
            android1.makeCall("6238000260");
            android1.useBattery(10);
            android1.printDetails();
            android1.installApp("Valorant");

            android1.GetLocation();
            android1.TakePhoto();
            

        }
    }

}
