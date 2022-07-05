using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar çarpım tablosunu ekrana
            int carpim = 1;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    carpim = i * j;
                    Console.WriteLine($"Sayıların çarpımı :{i} x {j} = {carpim}");
                    
                }
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
    }
}
