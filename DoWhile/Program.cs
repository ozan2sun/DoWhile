using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bugün kaç saat çalıştınız: ");
            //int kacSaat =Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("Eksik çalıştınız");
            //    kacSaat = kacSaat + 1;
            //} while (kacSaat <8);

            //1 den 100 e kadar 4ün katı sayıları toplatıp ekrana yazdıralım
            int toplam = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i %4 ==0)
                {
                    toplam += i;                  
                }
            }

            Console.WriteLine("1 den 100 e kadar 4ün katı sayıların toplamı: " + toplam);
            Console.ReadKey();
        }
    }
}
