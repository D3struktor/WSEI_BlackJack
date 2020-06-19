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
            Console.WriteLine("Witaj w kasynie, czy chcialbys zagrac w Black Jack?");
            Console.WriteLine("1.Gramy\n2.Odchodzisz od stołu");
            int gra = Convert.ToInt32(Console.ReadLine());
            while (gra <= 1)
            {
                
                int kartyGracza = 0;
                int kartyKrupiera = 0;

                Random random = new Random();

                kartyGracza += random.Next(2, 12); // Losowa liczba od 2 do 11
                kartyGracza += random.Next(2, 12); // Losowa liczba od 2 do 11

                kartyKrupiera += random.Next(2, 12); // Losowa liczba od 2 do 11
                Console.WriteLine("\n\nPierwsza karta krupiera to " + kartyKrupiera.ToString());
                kartyKrupiera += random.Next(2, 12); // Losowa liczba od 2 do 11

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
                    Console.WriteLine("Jesteś na: " + kartyGracza.ToString() + " Dobierasz?\nT lub N");

                    string odpowiedz = Console.ReadLine();

                    if (odpowiedz == "Tak" || odpowiedz == "tak" || odpowiedz == "t" || odpowiedz == "T")
                    {
                        kartyGracza += random.Next(2, 12); // Losowa liczba od 2 do 11
                        if (kartyGracza > 21)
                        {
                            Console.WriteLine("Masz za dużo oczek, Mission failed we will get him next time!");
                            break;
                        }

                        else
                        {
                            continue;
                        }
                    }

                    else if (odpowiedz == "Nie" || odpowiedz == "nie" || odpowiedz == "n" || odpowiedz == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna odpowiedź, spróbuj jeszcze raz!\nJeśli dobierasz wpisz Tak lub T\nJeśli zostajesz wpisz Nie lub N\n");
                        continue;
                    }

                }

                //Początek kolejki Krupiera
                Console.WriteLine("Jesteś na: " + kartyGracza.ToString());

                if (kartyGracza <= 21)
                {
                    //Jeśli gracz nie przegrał
                    while (kartyKrupiera < 21 && kartyKrupiera < kartyGracza)
                    {
                        kartyKrupiera += random.Next(2, 12); // Losowa liczba od 2 do 11
                    }
                    //Sprawdzamy kto wygrał
                    if (kartyGracza == kartyKrupiera)
                    {
                        Console.WriteLine("Gracz zremisował z krupierem!\n Macie po " + kartyGracza.ToString() + " puntków!");
                    }
                    else if (kartyGracza < kartyKrupiera && kartyKrupiera <= 21)
                    {
                        Console.WriteLine("Krupier wygrał z " + kartyKrupiera.ToString() + " punktami!");
                    }
                    else if (kartyKrupiera > 21)
                    {
                        Console.WriteLine("Gracz wygrywa! Krupier wtopił ;)\nWartość kart krupiera: " + kartyKrupiera.ToString());
                    }
                    else if (kartyKrupiera == 21)
                    {
                        Console.WriteLine("Krupier wygrał z 21 punkatmi!");
                    }
                }
                else
                {
                    Console.WriteLine("Krupier wygrał ale wtopa ;/\nWartość kart krupiera: " + kartyKrupiera.ToString());
                }
                Console.WriteLine("\nKrupier ponawia pytanie");
                Console.WriteLine("1.Gramy\n2.Odchodzisz od stołu");
                gra = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Dziekuje za gre.");
        }
        
    }
}
