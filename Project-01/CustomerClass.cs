using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class CustomerClass
    {
        // Sets the fields to Private, 
        // and declaring variables to the Class 'CustomerClass'. 
        private string NameOfCustomer;
        private int Age;
        private int Zipcode;
        private string Password;

        // Adding a constructor method called 'CustomerClass()', to the 'CustomerClass'.
        public CustomerClass()
        {
            // Initialize the fields of the Class ' CustomerClass'.
            this.NameOfCustomer = "Signe Frederiksen";
            this.Age = 23;
            this.Zipcode = 2300;
            this.Password = "124x53";
        }

        public override string ToString()
        {
            return "Name: " + NameOfCustomer + ", Age: " + Age + " year old, Zipcode: " + Zipcode + ", Password: " + Password + "";
        }
    }
}
