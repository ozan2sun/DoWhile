using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenKullaniciSayisinaKadarWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan sayıya kadar
            Console.WriteLine("Bir sayı yazınız: ");
            string sayi = (Console.ReadLine());
            int donenSayi;
            bool sayiMi;
            
            sayiMi = int.TryParse(sayi, out donenSayi);
            while (!sayiMi)
            {
                Console.WriteLine("Hatalı giriş! BİR SAYI YAZINIZ: ");
                sayi = Console.ReadLine();               
                sayiMi = int.TryParse(sayi, out donenSayi);
            }
            Console.WriteLine("-----------------");
            int sayac = 1;
            while (sayac<=donenSayi)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            Console.ReadKey();
        }
    }
}
