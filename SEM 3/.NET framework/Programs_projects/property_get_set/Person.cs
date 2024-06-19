using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_get_set
{
    public class Person
    {
        private string name; //field
        public string Name
        { //Property
            get { return name; }
            set { name = value; }
        }
    }
}
