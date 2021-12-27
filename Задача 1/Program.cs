using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Console.WriteLine("Введите семь значений");

            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());


            double S = 0, S2 = 0;

            for (int i = 0; i < 7; i++)
            {
                S += array[i];
            }

            S2 = S / 7;

            Console.WriteLine("Среднее арифметическое введенных чисел составляет {0}", S2);
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
