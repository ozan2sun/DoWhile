using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. görev seçin (taş kağıt makas)
            //2.görev seçimi kontrol ediniz
            //3.görev random seçeneği

            int playerScore = 0;
            int computerScore = 0;
            string exit="";
            while (exit != "h")
            {
                start:
                Console.Write("Taş(T),Kağıt(K),Makas(M)");
                string secim = Console.ReadLine().ToLower();
                switch (secim)
                {
                    case "t":
                        Console.WriteLine("Kullanıcı seçimi : Taş");
                        break;
                    case "m":
                        Console.WriteLine("Kullanıcı seçimi : Makas");
                        break;
                    case "k":
                        Console.WriteLine("Kullanıcı seçimi : Kağıt");
                        break;
                    default:
                        Console.WriteLine("Invalid input.... Try again");
                        goto start;
                        
                }

                Random rnd = new Random();
                int bilgisayar = rnd.Next(2);
                string tercih = "";
                switch (bilgisayar)
                {
                    case 0:
                        tercih = "t";
                        Console.WriteLine("Bilgisayar seçimi : Taş");
                        break;
                    case 1:
                        tercih = "k";
                        Console.WriteLine("Bilgisayar seçimi : Kağıt");
                        break;
                    case 3:
                        tercih = "m";
                        Console.WriteLine("Bilgisayar seçimi : Makas");
                        break;
                }
                if ((secim == "t" && tercih == "k") || (secim == "m" && tercih == "t") || (secim == "k" && tercih == "m"))
                {
                    Console.WriteLine("Bilgisayar kazandı.");
                    computerScore++;
                }
                else if ((secim == "k" && tercih == "t") || (secim == "t" && tercih == "m") || (secim == "m" && tercih == "k"))
                {
                    Console.WriteLine("İnsan kazandı.");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Berabere");
                }
                Console.WriteLine("Tekrar oynamak istiyor musunuz (E/H)");               
                exit = Console.ReadLine();
                
                
            }
            Console.WriteLine($"Bilgisayarın skoru: {computerScore} , Kullanıcı skoru: {playerScore}");
            Console.ReadKey();
                       
        }
    }
}
