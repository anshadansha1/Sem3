namespace GenericMethod
{
    internal class Program
    {
        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"inside the swap method a={a} b={b}");
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap<int>(a, b);
            Swap<string>("dilsha", "basheer");
            Console.WriteLine($"Before calling swap method a={a} b={b}");

        }
    }
}
