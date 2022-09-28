using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class lab3
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0; bool c = false;
            int count = 0;
            Console.WriteLine("№4\nВведите числа: ");
            while (a != -1)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == b) { c = true; count++;}
                b = a;
            }
            if (c) { Console.WriteLine("Повторяющиеся цифры - Имеются"); Console.Write("Количество повторяющихся цифр = "); Console.WriteLine(count.ToString());}
            else Console.WriteLine("Повторяющиеся цифры - Неимеются");
            
        }
    }
}