namespace Delegate_anonymous_function
{
    internal class Program
    {
        public delegate int SumDeligate(int x , int y);
        static void Main(string[] args)
        {
            SumDeligate sd1 = delegate(int x , int y) {  return x + y; };
            Console.WriteLine(sd1(20,30));
        }
    }
}
