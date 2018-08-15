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
            int result1 = Class1.mathOperation(12);
            Console.WriteLine(result1);
        }
    }

    public class NewClass
    {
        public int mathOperation(int Num1)
        {
            return Num1 + 5;
        }
    }
}
