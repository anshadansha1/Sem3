namespace threads
{
    internal class Program
    {
        static void PrintNumbers(string threadname)
        {
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine($"{threadname} :   {i}");
                Thread.Sleep( 500 ); //Pause for 500 milliseconds
            }
        }

        static void Main(string[] args)
            {
            Thread thread1 = new Thread(()=> PrintNumbers("Thread 1"));
            Thread thread2 = new Thread(()=> PrintNumbers("Thread 2"));

            thread1.Start();
            thread2.Start();

            Console.WriteLine("Main thread is continuing to run ...");

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Both thread have finished the execution");

        }
    }
}
