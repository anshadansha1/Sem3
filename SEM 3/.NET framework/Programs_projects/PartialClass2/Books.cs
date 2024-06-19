
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Books
    {
        public string Author_name;
        public string bookno;

        public void printDetails()
        {
            Console.WriteLine($"Author Name : {Author_name} \n Book number : {bookno}");

        }
    }

    public partial class Books
    {
        public string Bookname;
        public string publishername;

        public void PrintPublisherDetails(string bn,string pn)
        {
            this.Bookname = bn;
            this.publishername = pn;
            Console.WriteLine($"Book name : {Bookname} \n Publisher Name : {publishername}");

        }
    }

    public partial class Books
    {
        public static void Main(string[] args)
        {
            Books b1 = new Books();
            Console.WriteLine("Enter the Author name");
            b1.Author_name = Console.ReadLine();
            Console.WriteLine("Enter the Book no");
            b1.bookno = Console.ReadLine();
            b1.printDetails();
            Books b2 = new Books();
            b2.PrintPublisherDetails("Dilsha", "a002");
            //Console.WriteLine($"{Author_name} \n {bookno}");
        }

    }

}
