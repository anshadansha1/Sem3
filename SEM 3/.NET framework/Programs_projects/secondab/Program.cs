namespace secondab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone s1 = new Smartphone("Samsung", "S21FE", 35, "v4");
            s1.StartDevice();
            s1.UseDevice(); 
            s1.ShowDetails();

            Featurephone f1 = new Featurephone("Samsung", "Note 8", 20, 10);
            f1.StartDevice();
            f1.UseDevice();
            f1.ShowDetails();

        }
    }
}
