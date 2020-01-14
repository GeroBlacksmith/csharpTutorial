using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    abstract class Shape
    {
        public abstract double area();
        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }
}
