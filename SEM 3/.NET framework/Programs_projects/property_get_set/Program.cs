using System.Security.Cryptography.X509Certificates;

namespace property_get_set
{

    public class Program
    {
        //ENUM:enum is a special "class" that represents a group of constants 
        private enum Gender //enum 
        {
            Male,
            Female,
            Others
        }
        static void Main(string[] args)
        {
            //GET SET property Part :
            Person pobj1 = new Person();
            pobj1.Name = "Anshad";
            Console.WriteLine($"Name : {pobj1.Name}");

            //ENUM part
            Gender p1 = Gender.Male;
            Console.WriteLine($"Gender of p1 is {p1}");

            Gender p2 = Gender.Female;
            Console.WriteLine($"Gender of p2 is {p2}");

            
        }
    }
}
