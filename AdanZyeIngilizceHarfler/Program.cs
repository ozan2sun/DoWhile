using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdanZyeIngilizceHarfler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char harf = 'a'; harf <= 'z'; harf++)
            {
                Console.WriteLine(harf + " ");
            }
            string gelenKarakter = "";
            //3.yol
            for (int i = 97; i <= 122; i++)
            {
                gelenKarakter += Convert.ToChar(i);
            }
            Console.WriteLine("\r\n");
            Console.WriteLine($"ASCII Table ile gelen karakterler: {gelenKarakter}");

            // Büyük harfler için ASCII tablosu dönüşümü yapınız //65-90
            //Özel karakterler için ascii tablosu dönüşümünü yapınız (33-47 //58-64//91-96//123-126)
            string metin = "";
            for (int i = 65; i <= 90; i++)
            {
                metin +=Convert.ToChar(i);
            }
            Console.WriteLine(metin);

            string metin2 = "";
            for (int i = 33; i <= 126; i++)
            {
                if (i<=47)
                {
                    metin2 += Convert.ToChar(i);
                }
                else if (i>=58 && i<=64)
                {
                    metin2 += Convert.ToChar(i);
                }
                else if (i >= 91 && i <= 96)
                {
                    metin2 += Convert.ToChar(i);
                }
                else if (i >= 123 && i <= 126)
                {
                    metin2 += Convert.ToChar(i);
                }
                
            }
            Console.WriteLine(metin2);
            Console.ReadKey();
        }
    }
}
