using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Animal
    {
        public double height { get; set; }
        public double weigth { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weigth = 0;
            this.sound = "no sound";
            this.name = "no name";
            numOfAnimals++;
        }

        public Animal(double height, double weigth, string name, string sound)
        {
            this.height = height;
            this.weigth = weigth;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }
        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}.", name, height, weigth, sound);
        }
        public int getSums(int num1=1, int num2 = 1)
        {
            return num1 + num2;
        }
        public double getSums(double num1=1.0, double num2 = 1.0)
        {
            return num1 + num2;
        }

    }
}
