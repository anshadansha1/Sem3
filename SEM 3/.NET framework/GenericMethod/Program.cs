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
        public void Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine($"Sum of {a} and {b} is {sum}");
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            //if method is static no need object to call it.We can directly 
            Swap<int>(a, b);
            Swap<string>("dilsha", "basheer");
            Console.WriteLine($"Before calling swap method a={a} b={b}");
            
            //To access method ,when method is declared as public
            Program obj = new Program();
            obj.Add(a,b);

        }
    }
}
