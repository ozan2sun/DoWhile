using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanAlinanMetniKullanicidanAlinanSayiKadarYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Yazmak istediğiniz metni girin: ");
            string metin = Console.ReadLine();
        start:
            Console.WriteLine("Kaç adet girmek istiyorsunuz: ");
            string adet = Console.ReadLine();

            bool sayiMi;
            int donenSayi;

            sayiMi = int.TryParse(adet, out donenSayi);

            while (!sayiMi)
            {
                Console.WriteLine("Hatalı giriş ! Kaç adet girmek istiyorsunuz: ");
                adet = Console.ReadLine();
                sayiMi = int.TryParse(adet, out donenSayi);
            }
            if (0 >donenSayi)
            {
                Console.WriteLine("Sıfırdan küçük sayı girilmez");
                goto start;
            }

            for (int i = 1; i <= donenSayi; i++)
            {
                Console.WriteLine($"{i}.kez {metin}");
            }
            Console.ReadKey();
        }
    }
}
