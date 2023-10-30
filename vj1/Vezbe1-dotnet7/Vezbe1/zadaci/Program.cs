using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using zadaci;

namespace vjezba
{
    internal class zadaci
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Unesi broj n: ");
            //int n =Convert.ToInt32( Console.ReadLine());
            //int fb=0;

            //if(n>0 && n < 3)
            //{
            //    fb = 1;
            //}
            //if(n>2)
            //{
            //    List<int> pomocni = new List<int>();
            //    pomocni.Add(1);
            //    pomocni.Add(1);
            //    for(int i = 0; i < n; i++)
            //    {
            //        pomocni[0] = pomocni[1];
            //        pomocni[1] = fb;
            //        fb = pomocni[0] + pomocni[1];
            //    }
            //}

            //Console.WriteLine($"N-ti clan fibonicejovog niza za n={n} iznosi {fb}");

            //Console.WriteLine("Unesite string za provjeru");
            //string s = Console.ReadLine();
            //bool b = true;

            //string pom = s.ToLower();
            //string neki=pom.Replace(" ","");

            //int duz = neki.Length;

            //for (int i = 0;i < duz/2; i++)
            //{
            //    if (neki[i] != neki[duz-i-1]) { b = false;
            //        continue;
            //    }
            //}

            //Console.WriteLine($"Unijeti string {s} \n{neki} ");
            //if (b)
            //{
            //    Console.WriteLine("Jeste palindrom");
            //}
            //else
            //{
            //    Console.WriteLine("Nije palindrom");
            //}

            Motor m1= new Motor();
            Motor m3 = new Motor();
            Motor m2= new Motor("Elektricni",2.5,120);
            Automobil a1 = new Automobil();
            Automobil a2 = new Automobil("Suv","Ford","plava",2020,VrstaGoriva.benzin,m1);

            m1.naziv = "Kombinovani";
            m1.naziv = "Sus";
            if (m1.Equals(m3))
            {
                Console.WriteLine("Motori su jednaki");
            }
            else
            {
                Console.WriteLine("Nisu jednaki");
            }

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
        }
    }
}
