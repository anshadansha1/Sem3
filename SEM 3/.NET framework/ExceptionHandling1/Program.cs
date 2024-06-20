namespace ExceptionHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // String Array
                string[] stringArray = new string[10];

                //Add elements to the array
                stringArray[0] = "Anshad";
                Console.WriteLine(stringArray[0]);
                //The following line will cause an ArraTypeMismatchException
                //bcs you are trying to assign an integer to a string array element.
                //Correcting it to ilustrate exception handling :
                object obj = 0; //Using an object to demonstrate typeMismatch
                stringArray[1] = (string)obj; //Even when you  typescase this ,it will fail at runtime

                Console.WriteLine("No Exception Occured");
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2);
            }
        }
    }
}
