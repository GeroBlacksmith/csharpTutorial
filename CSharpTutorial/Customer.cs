using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    struct Customer
    {
        private string name;
        private double balance;
        private int id;

        public void createCostumer(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("Id " + id);

        }
    }
}
