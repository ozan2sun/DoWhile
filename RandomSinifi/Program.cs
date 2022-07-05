using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3tane random zar attırınız (1-6 aralığı)
            //Zarlardan 3tanesi eşit gelirse kullanıcı 6 puan kazanır
            //Zarlardan 2 tanesi eşit gelirse 2 puan kazanır.
            // kullanıcı 15 puanı geçerse oyun biter
            // toplam oynanan el sayısı

            int puan = 0;
            int sayac = 0;
            Random rnd = new Random();
            int zar1, zar2, zar3;
            while (puan <=15)
            {
                zar1 = rnd.Next(1, 7);
                zar2 = rnd.Next(1, 7);
                zar3 = rnd.Next(1, 7);
                Console.WriteLine("Birinci zar: " + zar1);
                Console.WriteLine("İkinci zar :" + zar2);
                Console.WriteLine("Üçüncü zar :" + zar3);
                Console.WriteLine("----------------------");
                if (zar1 == zar2 && zar1 == zar3 && zar2 ==zar3)
                {
                    puan += 6;
                    
                }
                else if (zar1 == zar2 || zar2 == zar3 || zar1 == zar3)
                {
                    puan += 2;
                    
                }
                sayac++;
            }
            Console.WriteLine("Toplamda " + sayac + " adım gidilmiştir.");
            Console.ReadKey();
            
        }
    }
}
