using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SosninFM.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SosninFM.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a + b = " + DataService.Addition(1,5));
            Console.WriteLine("a - b = " + DataService.Substraction(15, 5));
            Console.WriteLine("a * b = " + DataService.Multiplication(10, 10));
            Console.WriteLine("a / b = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}
