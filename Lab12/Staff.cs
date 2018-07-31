using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff:Person
    {
        private string Name;
        private string Address;
        private string School;
        private double Pay;

        public Staff (string name, string address, string school, double pay):base(name,address)
        {
            Name = name;
            Address = address;
            School = school;
            Pay = pay;
        }

        public Staff ()
        { }

        override
        public string ToString()
        {
            return $" Staff {base.ToString()}, school = {this.School}, pay = {this.Pay}";
        }

    }
}
