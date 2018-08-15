using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step114
{
    class Program
    {
        static void Main(string[] args)
        {
            NewClass Class1 = new NewClass();
            int result1 = Class1.MathOperation(12);
            Console.WriteLine(result1);
            Console.ReadLine();

            NewClass Class2 = new NewClass();
            decimal NotAnInt = 1.42m;
            decimal result2 = Class2.MathOperation(NotAnInt);
            Console.WriteLine(result2);
            Console.ReadLine();

            NewClass Class3 = new NewClass();
            int result3 = Class3.MathOperation("5");
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }

    public class NewClass
    {
        public int MathOperation(int Num1)
        {
            return Num1 + 5;
        }

        public int MathOperation(decimal Num2)
        {
            int Num3 = Convert.ToInt32(Num2 * 100);
            return Num3;
        }

        public int MathOperation(string Num4)
        {
            try
            {
                int Num5 = Convert.ToInt32(Num4) - 2;
                return Num5;
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a number. Here is a number: ");
                return 5;
            }
        }
    }
}
