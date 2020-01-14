using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Numerics;
delegate double GetSum(double num1, double num2);
namespace CSharpTutorial
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // Variables();
            // MathOperations();
            // Casting();
            // MathFunctions();
            // Relations();
            // Looping();
            // StringsMethods();
            // FormatStrings();
            // StringBuilders();
            // MatricesInteger();
            // MatrizMultiDimensional();
            // ListsMethods();
            // Excepciones();
            // ClassesExample();
            // PolymorphismExample();
            // GenericExample();
            // EnumExample();
            // StrucExample();
            // DelegateExample();
            // LambdaExample();
            // AdvancedListExample();
            FileIOExample();

        }

        private static void FileIOExample()
        {
            string[] custs = new string[] { "Tom", "Paul", "Greg" };
            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }
            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
        }

        private static void AdvancedListExample()
        {
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();
            foreach(int num in oddNums)
            {
                Console.WriteLine(num + ", ");
            }
        }

        private static void LambdaExample()
        {
            Func<int, int, int> getSum = (x, y) => x + y;
        }

        private static void DelegateExample()
        {
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };
            Console.WriteLine("5 + 10 = " + sum(5, 10));
        }

        private static void StrucExample()
        {
            Customer bob = new Customer();
            bob.createCostumer("Bob", 10.14, 50);
            bob.showCust();
        }

        private static void EnumExample()
        {
            Temperature micTemp = Temperature.Warm;
            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
                default:
                    break;
            }
        }

        private static void GenericExample()
        {
            KeyValue<string, string> superma = new KeyValue<string, string>("", "");
            superma.key = "Superma";
            superma.value = "Clar Ken";
            KeyValue<int, string> samsungTV= new KeyValue<int, string>(0 ,"" );
            samsungTV.key = 122345;
            samsungTV.value = "A 50 inch samsung tv";
            superma.ShowData();
            samsungTV.ShowData();
        }

        private static void PolymorphismExample()
        {
            Shape rectangle = new Rectangle(5, 5);
            Shape triangle = new Triangle(2, 4);

            Console.WriteLine("Rectangle Area" + rectangle.area());
            Console.WriteLine("Triangle Area" + triangle.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(4,4);
            Console.WriteLine("Rectangle Area" + combRect.area());
        }

        private static void ClassesExample()
        {
            Animal spot = new CSharpTutorial.Animal(15, 10, "Spot", "Woof");
            Console.WriteLine("{0} says {1}", spot.name, spot.sound);
            Console.WriteLine("Number of animals: " + Animal.getNumOfAnimals());
            Console.WriteLine(spot.toString());
            Console.WriteLine(spot.getSums(1.2, 2.3));
            Console.WriteLine(spot.getSums(num2:1 , num1:2));
            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weigth = 18,
                sound = "Grrr"
            };
            Dog spike = new Dog();
            Console.WriteLine(spike.toString());
            spike = new CSharpTutorial.Dog(15, 20, "spike", "Grrr", "chimken");
            Console.WriteLine(spike.toString());
        }

        private static void Excepciones()
        {
            try
            {
                Console.Write("Divide by 0");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0}={1}", num, (10 / num));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
                throw new InvalidOperationException("Operation invalid", e);
                // throw new InvalidOperationException("Hola", e);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListsMethods()
        {
            List<int> numList = new List<int>();
            numList.Add(12);
            numList.Add(21);
            numList.Add(31);
            numList.Add(51);

            int[] array = { 1, 2,3, 4, 5 };
            numList.AddRange(array);
            //numList.Clear();
            List<int> numList2 = new List<int>(array);
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            numList.Insert(1, 10);
            numList.Remove(5);
            numList.RemoveAt(2);
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
            Console.WriteLine("2 is in index "+numList3.IndexOf(2));
            Console.WriteLine("5 in List " + numList3.Contains(5));

            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

            Console.WriteLine("Tom in List" + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            strList.Sort();
        }

        private static void MatrizMultiDimensional()
        {
            int[,] multiArray = new int[3, 5];
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 45, 5 } };
            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }
            for (int i = 0; i < multArray2.GetLength(0); i++)
            {
                for (int j = 0; j < multArray2.GetLength(1); j++)
                {
                    Console.WriteLine("{0}|{1}:{2}", i, j, multArray2[i, j]);
                }
            }
        }

        private static void MatricesInteger()
        {
            int[] randNumArray;

            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));
            Console.WriteLine("Array Length" + randArray2.Length);

            Console.WriteLine("Item 0 " + randArray2[0]);

            for(int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, randArray2[i]);
            }

            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }

            string[] names = { "Tom", "Paul", "Sally" };

            string nameStr = string.Join(", ", names);

            string[] nameArray = nameStr.Split(',');
        }

        private static void StringBuilders()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is my first sentence");
            sb.AppendFormat("My name is {0} and I live in {1}", "Gerardo","Neuquen");
            sb.Replace("a", "e");
            sb.Remove(5, 7);
            Console.WriteLine(sb.ToString());
            //sb.Clear();

        }

        private static void FormatStrings()
        {
            string fmtString = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(fmtString);
        }

        private static void StringsMethods()
        {
            string sampString = "A bunch of random words";
            Console.WriteLine("Is EMpty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is EMpty " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("Is EMpty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("String lenght " + sampString.Length);
            Console.WriteLine("Index of bunch: " + sampString.IndexOf("bunch"));
            Console.WriteLine("2nd word " + sampString.Substring(2));
            string sampString2 = "More random words";
            Console.WriteLine("String equals" + sampString.Equals(sampString2));
            Console.WriteLine("Starts with \"A bunch\"" + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with \"words\"" + sampString.EndsWith("A bunch"));
            sampString.Trim(); //TrimEnd TrimStart
            sampString = sampString.Replace("words","characters");
            Console.WriteLine(sampString);
            sampString = sampString.Remove(0,2);
            Console.WriteLine(sampString);

            string[] names = new String[3] { "Matt","Joe","Paul"};

            Console.WriteLine("Name List: " + String.Join(", ", names));
        }

        private static void Looping()
        {
            string guess;
            do
            {
                Console.WriteLine("Guess the number.");
                guess = Console.ReadLine();

            } while (!guess.Equals("15"));

            string randStr = "Here some random characters";
            foreach(char i in randStr)
            {
                Console.WriteLine(i);
            }
        }

        // Relational operators > < >= <= == !=
        // Logical operators && || ^(exclusive or) !
        private static void Relations()
        {
            int age = 17;

            if((age>= 5) && (age <= 7))
            {
                Console.WriteLine("Go to Elementary School.");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle School");
            }
            else
            {
                Console.WriteLine("Go To High School");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            switch (age)
            {
                case 0:
                    Console.WriteLine("infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    break;
                case 3:
                    //goto Label;
                default:
                    Console.WriteLine("Child");
                    break;
            }
        //Label:
          //  Console.WriteLine("Outside switch");
            bool canDrive = age >= 16 ? true : false;

        }
        private static void MathFunctions()
        {
            // MATH FUNCTIONS:
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1): " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1): " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1): " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2): " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2): " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2): " + (Math.Pow(number1,2)));
            Console.WriteLine("Math.Round(number1): " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1): " + (Math.Sqrt(number1)));

            string exit = "yes";
            Random rand = new Random();
            while (exit == "yes" || exit == "y" )
            {
                Console.WriteLine("Random num: " + rand.Next(1,11));
                Console.WriteLine("Do you want another random value? (y)es, no");
                exit = Console.ReadLine();
            }

        }

        static void Casting()
        {
            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine("Int Pi: " + intPi);
        }
        static void MathOperations()
        {
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));
            int i = 0;

            Console.WriteLine("i++ " + (i++));
            Console.WriteLine("++i " + (++i));
            Console.WriteLine("i-- " + (i--));
            Console.WriteLine("--i " + (--i));

            Console.WriteLine("i+=3 " + (i += 3));
            Console.WriteLine("i-=2 " + (i -= 2));
            Console.WriteLine("i*=2 " + (i *= 2));
            Console.WriteLine("i/=2 " + (i /= 3));
            Console.WriteLine("i%=2 " + (i %= 2));
        }
        static void Variables()
        {
            bool flag = true; //or false
            if (flag)
            {
                Console.WriteLine("The flag is true");
            }
            else
            {
                Console.WriteLine("The flag is false");
            }

            char letter = 'A'; // single quotes as in Java chars
            // single 16 bit unicode
            Console.WriteLine("Char ");
            Console.WriteLine(letter);

            // Integer with maximun numbre of 2,147,483,647
            int maxInt = int.MaxValue;
            Console.WriteLine("Max Int:");
            Console.WriteLine(maxInt);

            // Long with max number of 9,223,372,036,845,775,807
            long maxLong = long.MaxValue;
            Console.WriteLine("Max Long: ");
            Console.WriteLine(maxLong);

            // Decimal has a maximun value of 79,228,162,514,264,337,593,543,950,335
            // if you need something bigger look up to BigInteger
            decimal maxDec = decimal.MaxValue;
            Console.WriteLine("Max Decimal");
            Console.WriteLine(maxDec);

            // A float is a 32 bit number with a MaxValue of 3.402823E+38 with 7 decimal precision
            float maxFloat = float.MaxValue;
            Console.WriteLine("Max FLoat");
            Console.WriteLine(maxFloat);

            // A double is a number with mxValue of 1.797893134E+308 with 15 decimals of presicion
            double maxDou = double.MaxValue;
            Console.WriteLine("Max double");
            Console.WriteLine(maxDou);

            // BigInteger bigInteger = bigInteger.MaxValue;

            // var define el tipo en tiempo de compilación pero luego no puede cambiar a otro tipo
            var anotherName = "Tom";
            anotherName = "Max";
            // anotherName = 1;

            //obtener el tipo de una variable var
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
        }
        static void Comments()
        {
            // One line comment

            /**
             * Multiline comment
             */
        }
        static void HelloWorld()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
