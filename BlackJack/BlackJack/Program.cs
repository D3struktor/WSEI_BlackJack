using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int kartyGracza = 0;
            int kartyKrupiera = 0;

            Random random = new Random();

            kartyGracza += random.Next(1, 12); // Losowa liczba od 1 do 11
            kartyGracza += random.Next(1, 12); // Losowa liczba od 1 do 11

            kartyKrupiera += random.Next(1, 12); // Losowa liczba od 1 do 11
            kartyKrupiera += random.Next(1, 12); // Losowa liczba od 1 do 11

            switch (karty)
            {
                case 1:
                case 11:
                    Console.WriteLine("Ace of Spades");
                    break;
                case 2:
                    Console.WriteLine("Dwójka");
                    break;

                case 3:
                    Console.WriteLine("Trójka");
                    break;
                case 4:
                    Console.WriteLine("Czwórka");
                    break;
                case 5:
                    Console.WriteLine("Piątka");
                    break;
                case 6:
                    Console.WriteLine("Szóstka");
                    break;
                case 7:
                    Console.WriteLine("Siódemka");
                    break;
                case 8:
                    Console.WriteLine("Ósemka");
                    break;
                case 9:
                    Console.WriteLine("Dziewiątka");
                    break;
                case 10:
                    Console.WriteLine("Dziesiątka, Walet, Królowa, Król");
                    break;
                default:
                    Console.WriteLine("Joker");
                    break;
            }
            Console.ReadLine();
        }
    }
}
