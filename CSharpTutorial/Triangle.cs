using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Triangle : Shape
    {
        private double baseWidth;
        private double heigth;
        public Triangle(double baseWidth, double heigth)
        {
            this.baseWidth = baseWidth;
            this.heigth = heigth;
        }
        public override double area()
        {
            return (this.baseWidth * this.heigth) / 2;
        }
    }
}
