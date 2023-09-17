using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SosninFM.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SosninFM.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // сложение
            Console.WriteLine(DataService.Addition(1, 4353));
            // вычитание
            Console.WriteLine(DataService.Substraction(226, 2));
            // умножение
            Console.WriteLine(DataService.Multiplication(3, 4));
            // деление
            Console.WriteLine(DataService.Division(25, 5));

            Console.ReadKey();

        }
    }
}
