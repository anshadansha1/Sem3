namespace DelegateExample
{
    //Delegate Declaration:
    delegate int ArithOp(int x, int y);
    delegate void MDelegate();

    public class Program
    {
        static void Main(string[] args)
        {
            //Delegate instances:
            ArithOp operation1 = new ArithOp(MathOperation.Add);
            ArithOp operation2 = new ArithOp(MathOperation.Sub);

            //Invoking delegates:
            int result1 = operation1(200, 100);
            int result2 = operation2(200, 100);
            Console.WriteLine("Result 1 = " + result1);
            Console.WriteLine("Result 2 = " + result2);

            //Multicast Delegate :-
            MDelegate m1 = new  MDelegate(DM.Display);
            MDelegate m2 = new MDelegate(DM.Print);

            MDelegate m3 = m1 + m2;
            MDelegate m4 = m2 + m1;
            MDelegate m5 = m3 - m2;

            m3();
            m4();
            m5();
        }
    }
}
