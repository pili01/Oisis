using System;

namespace Uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicijalizacija varijabli i njihov ispis na konzoli
            string ime = "Radoslav";
            Console.WriteLine("Moje ime je " + ime);

            int mojBroj = 20;
            Console.WriteLine("Moj broj je " + mojBroj);

            char slovo = 'A';
            Console.WriteLine("Odabrano slovo je " + slovo);

            bool mojBool = true;
            Console.WriteLine("Moj boolean " + mojBool);

            // Tipovi
            Console.WriteLine("Tip broja je: " + mojBroj.GetType());
            
            // Implicitna konverzija iz int u double
            double mojDouble = mojBroj;
            Console.WriteLine("Tip broja posle konverzije je: " + mojDouble.GetType() + "\n");

            double mojNoviDouble = 5.2;
            Console.WriteLine("Tip broja je: " + mojNoviDouble.GetType());

            // Eksplicitna konverzija iz int u double
            int mojNoviBroj = (int)mojDouble;
            Console.WriteLine("Tip broja posle konverzije je: " + mojNoviBroj.GetType() + "\n");

            // Konverzija int u string
            int noviBroj = 10;
            Console.WriteLine("Tip broja je: " + noviBroj.GetType());
            Console.WriteLine("Tip broja posle konverzije je: " + Convert.ToString(noviBroj).GetType());

            // Ucitavanje sa konzole
            Console.WriteLine("Unesite korisnicko ime: ");

            string korisnickoIme = Console.ReadLine();

            Console.WriteLine("Korisnicko ime je: " + korisnickoIme);
            Console.WriteLine("Korisnicko ime ispisano velikim slovima: " + korisnickoIme?.ToUpper());

            
            int testBroj = 25;

            Console.WriteLine("Primer grananja");
            if (testBroj < 10)
            {
                Console.WriteLine("Broj je manji od 10.");
            }
            else if (testBroj < 22)
            {
                Console.WriteLine("Broj je manji od 22.");
            }
            else
            {
                Console.WriteLine("Broj je velik.");
            }


            Console.WriteLine("\nFOR petlja");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\nWHILE");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\nSWITCH");
            int broj = 1;
            switch (broj)
            {
                case 1:
                    Console.WriteLine("Ponedeljka");
                    break;
                case 2:
                    Console.WriteLine("Utorak");
                    break;
            }


            // zadatak 1. Dopuniti funkciju tako da se omogući korisniku da unese ime, prezime, grad, omiljenu boju i godinu rođenja.
            //            Sve podatke ispisati na konzoli. Grad ispisati velikim slovima, a omiljenu boju malim slovima.

            
            
        }
    }
}