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

        public void PrintPublisherDetails()
        {
            Console.WriteLine($"Book name : {Bookname} \n Publisher Name : {publishername}");

        }
    }

    public partial class Books
    {
        public static void main(string[] args)
        {
            Books b1 = new Books();
            b1.printDetails();
            //Console.WriteLine($"{Author_name} \n {bookno}");
        }

    }

}
