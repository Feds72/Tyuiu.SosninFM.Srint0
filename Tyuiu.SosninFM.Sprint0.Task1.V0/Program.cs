using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SosninFM.Sprint0.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            string name = "Фёдор";
            int age = 18;
            Console.WriteLine($"Здравствуйте, меня зовут {name}, мне {age} лет ");
            Console.WriteLine("Здравствуйте, меня зовут " + name + "," + " мне " + age + " лет ");
            Console.ReadKey();
            

        }
    }
}
