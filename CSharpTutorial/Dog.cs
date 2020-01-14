using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Dog:Animal
    {
        public string favFood { get; set; }
        public Dog():base()
        {
            this.favFood = "No favorite";
        }
        public Dog(double height, double weigth, string name, string sound, string favFood):base(height,weigth, name,sound)
        {
            this.favFood = favFood;
        }
        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}.", name, height, weigth, sound, favFood);
        }
    }
}
