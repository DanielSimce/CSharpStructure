using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Functions
{
    class Program
    {
        struct CustomerName
        {
            public string firstName, lastName;
            public string Name() => firstName + " " + lastName;
        }

        static void Main(string[] args)
        {
            CustomerName myCustomer;
            myCustomer.firstName = "Daniel";
            myCustomer.lastName = "Simonovski";
            Console.WriteLine($"{myCustomer.firstName} {myCustomer.lastName}");
            Console.WriteLine(myCustomer.Name());
            Console.ReadLine();
        }
    }
}
