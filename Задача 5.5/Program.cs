using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++, Console.WriteLine())
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;

                    Console.Write("{0} ", array[i, j]);
                }

                 
            }
            Console.ReadKey();
        }
      
    }
    
}
