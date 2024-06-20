using System.Collections.Generic;

namespace GenericClass
{

    internal class Program 
    {
        static void Main(string[] args)
        {
            Generic<int> obj = new Generic<int>();
            obj.AddElement(123);
            obj.AddElement(856);
            obj.Display();
            obj.RemoveElement(856);
            obj.Display();
            Generic<string> obj2 = new Generic<string>();
            obj2.AddElement("Merin");
            obj2.AddElement("856");
            obj2.Display();
            obj2.RemoveElement("856");
            obj2.Display();
        }
    }
}
