using System;

namespace KlawiaturaNumeryczna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sprawdz = true;

            Klawiatura klawiatura = new Klawiatura();

            while (sprawdz)
            {
                Console.WriteLine("\n**** MENU ****");
                Console.WriteLine("\n1. Przedstaw słowo za pomocą ciągu liczb z klawiatury" +
                    "\n2. Napisz słowo za pomocą klawiatury numerycznej" +
                    "\n3. Wyświetl klawiaturę" +
                    "\n0. Wyjście" +
                    "\n\nWybierz z menu: ");

                int wybor = Convert.ToInt16(Console.ReadLine());

                switch (wybor)
                {
                    case 1: klawiatura.SlowoNaKlawisze();
                        break;
                    case 2: klawiatura.KlawiszeNaSlowo();
                        break;
                    case 3: klawiatura.WyswietlKlawiature();
                        break;
                    case 0: sprawdz = false; 
                        break;                 
                }

            }
        }
    }
}
