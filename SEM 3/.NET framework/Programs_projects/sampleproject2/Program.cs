namespace sampleproject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            long myNum = 15000000;
            Console.WriteLine(myNum);
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //Automatic casting:Int to Double
            myInt = (int)myDouble;
            Console.WriteLine(myDouble);

            //Program :To display Day
            Console.WriteLine("\nEnter a num b/w 1 to 7 to find the day:" );
            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            //PROGRAM : Odd or Even
            Console.WriteLine("Enter the num to find Odd or Even : ");
            int num = int.Parse(Console.ReadLine());
        
            if(num%2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if(num == 0)
            {
                Console.WriteLine("Number is Neither Odd Nor Even");
            }
            else
            {
                Console.WriteLine("ODD");
            }

            //Program : Factorial

            int i, fact = 1, num2;
            Console.WriteLine("\nEnter the number to find factorial");
            num2 = int.Parse(Console.ReadLine());
            for(i = 1; i <= num2; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nFactorial = ", fact);

           
        }
    }
}
