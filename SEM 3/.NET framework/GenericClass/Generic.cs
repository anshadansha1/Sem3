using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace GenericClass
{
    class Generic<T>
    {
        private List<T> elements = new List<T>();
        public void AddElement(T element)
        {
            elements.Add(element);
        }
        public void RemoveElement(T element)
        {
            elements.Remove(element);
        }
        public void Display()
        {
            foreach (T element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
