using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double num1, double num2)
        {
            this.length = num1;
            this.width = num2;
        }
        public override double area()
        {
            return length * width;
        }
        public static Rectangle operator+(Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;
            return new Rectangle(rectLength, rectWidth);
        }
    }
}
