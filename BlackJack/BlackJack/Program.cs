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

            if (kartyGracza > 21)
            {
                kartyGracza -= 10; //zabezpieczenie przed natychmiastową przegraną gracza
            }

            if (kartyKrupiera > 21)
            {
                kartyKrupiera -= 10; //zabezpieczenie przed natychmiastową przegraną krupiera
            }


            //Początek kolejki gracza
            while (true)
            {
                if (kartyGracza == 21)
                {
                    Console.WriteLine("Jesteś na 21!!");
                    break;
                }
                Console.WriteLine("Jesteś na: " + kartyGracza.ToString() + "Dobierasz?");

                string odpowiedz = Console.ReadLine();

                if (odpowiedz == "Tak" || odpowiedz == "tak" || odpowiedz == "t" || odpowiedz == "T")
                {

                }

                else if(odpowiedz == "Nie" || odpowiedz == "nie" || odpowiedz == "n" || odpowiedz == "N")
                {

                }
                else
                {
                    Console.WriteLine("Niepoprawna odpowiedź, spróbuj jeszcze raz\nJeśli dobierasz wpisz Tak lub T/Jeśli zostajesz wpisz Nie lub N");
                    continue;
                }

            }
            Console.ReadLine();
        }
    }
}
