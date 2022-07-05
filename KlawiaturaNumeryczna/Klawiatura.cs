using System;
using System.Collections.Generic;
using System.Linq;

namespace KlawiaturaNumeryczna
{
    public class Klawiatura
    {
        public Dictionary<char, string> NowaKlawiatura()
        {
           Dictionary<char, string> klawisze = new Dictionary<char, string>();

            klawisze.Add('A', "2");
            klawisze.Add('B', "22");
            klawisze.Add('C', "222");
            klawisze.Add('D', "3");
            klawisze.Add('E', "33");
            klawisze.Add('F', "333");
            klawisze.Add('G', "4");
            klawisze.Add('H', "44");
            klawisze.Add('I', "444");
            klawisze.Add('J', "5");
            klawisze.Add('K', "55");
            klawisze.Add('L', "555");
            klawisze.Add('M', "6");
            klawisze.Add('N', "66");
            klawisze.Add('O', "666");
            klawisze.Add('P', "7");
            klawisze.Add('Q', "77");
            klawisze.Add('R', "777");
            klawisze.Add('S', "7777");
            klawisze.Add('T', "8");
            klawisze.Add('U', "88");
            klawisze.Add('V', "888");
            klawisze.Add('W', "9");
            klawisze.Add('X', "99");
            klawisze.Add('Y', "999");
            klawisze.Add('Z', "9999");

            return klawisze;          
        }

        public void SlowoNaKlawisze() 
        {
            Console.Clear();

            var klawisze = NowaKlawiatura();

            Console.WriteLine("Podaj słowo jakie chcesz przedstawić " +
                "za pomogą ciągu klawiszy z klawiatury: ");

            var litery = Console.ReadLine().ToUpper().ToCharArray();

            try
            {
                foreach (var litera in litery)
                {
                    Console.Write(klawisze[litera] + " ");
                }
                Console.WriteLine("");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Wprowadzono błędny znak, spróbuj ponownie", exp);
            }

            Console.WriteLine("\n\nWciśnij ENTER, zby wrócić do menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void KlawiszeNaSlowo()
        {
            Console.Clear();

            WyswietlKlawiature();

            List<char> slowo = new List<char>();

            var klawiatura = NowaKlawiatura();

            bool check = true;

            Console.WriteLine("\nKażdą literę zaakceptuj przyciskiem ENTER\n");

            while (check)
            {
                Console.Write("Wpisz litere: ");
                var ciagLiczb = Console.ReadLine();

                if (ciagLiczb != "")
                {
                    var litera = klawiatura.FirstOrDefault(x => x.Value == ciagLiczb).Key;
                    
                    if (litera != 0)
                    {
                        slowo.Add(litera);
                    }
                    else
                        check = false;
                }
                else
                    break;
            }

            if (check)
            {
                Console.Write("\nTwoje słowo to: ");

                foreach (var slowa in slowo)
                {
                    Console.Write(slowa);
                }
            }
            else
            {
                Console.WriteLine("\nWprowadzone błędne dane, spróbuj jeszcze raz");
            }                        

            Console.WriteLine("\n\nWciśnij ENTER, zby wrócić do menu");
            Console.ReadKey();
            Console.Clear();
           
        }

        public void WyswietlKlawiature()
        {
            Console.Clear();
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("|   1    |    2     |    3   |");
            Console.WriteLine("|        |   ABC    |   DEF  |");
            Console.WriteLine("|________|__________|________|");
            Console.WriteLine("|   4    |    5     |    6   |");
            Console.WriteLine("|  GHI   |   JKL    |   MNO  |");
            Console.WriteLine("|________|__________|________|");
            Console.WriteLine("|   7    |    8     |    9   |");
            Console.WriteLine("| PQRS   |   TUV    |  WXYZ  |");
            Console.WriteLine("|________|__________|________|");
            Console.WriteLine("|        |    0     |        |");
            Console.WriteLine("|        |   EXIT   |        |");
            Console.WriteLine("|________|__________|________|");
            
        }

    }
}
