using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        private string Name;
        private string Address;

        public Person (string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person()
        { }

        override
        public string ToString()
        {
            return $" Person [name = {this.Name}, address = {this.Address}]";
        }
        
        

    }
   

}
