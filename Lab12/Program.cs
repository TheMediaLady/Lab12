using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Justin = new Person("Justin", "Grand Circus");
            Person Aquoinette = new Person("Aquoinette", "Birmingham, AL");
            Console.WriteLine(Justin.ToString() +"\n \n"+ Aquoinette.ToString());

            Student Lisa = new Student("Lisa", "Lansing, MI", "C#.Net", 2018, 17.55);
            Console.WriteLine("\n" + Lisa.ToString());

            Staff John = new Staff("John", "Grand Rapids", "Grand Circus GR", 150.25);
            Console.WriteLine("\n" + John.ToString());
            
            Console.ReadLine();
        }
    }
}
