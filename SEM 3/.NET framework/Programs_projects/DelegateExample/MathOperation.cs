using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class MathOperation
    {
        //Delegate Method definition:
        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static int Sub(int a, int b)
        {
            return (a - b);
        }
    }
}
