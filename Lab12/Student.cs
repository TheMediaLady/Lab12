using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student :Person
    {
        private string Name;
        private string Address;
        private string Program;
        private int Year;
        private double Fee;

        public Student (string name, string address, string program, int year, double fee): base (name, address)
        {
            Name = name;
            Address = address;
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student()
        { }

        override
       public string ToString()
        {
            return $" Student { base.ToString()},  program = {this.Program}, year = {this.Year}, fee = {this.Fee} ]";
        }

    }
}
