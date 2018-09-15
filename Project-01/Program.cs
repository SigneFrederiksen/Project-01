using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerClass myFirstCustomer = new CustomerClass();

            Console.WriteLine("My first customer is: " + myFirstCustomer.ToString());
        }
    }
}
