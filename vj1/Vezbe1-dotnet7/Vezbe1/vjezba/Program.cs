using System;
using vjezba;

namespace Zadatak
{
    enum dani { pon,uto};
    class Mejn
    {
        static void Main(string[] args)
        {
            Automobil a=new Automobil();
            Automobil a1 = new Automobil("plava");
            a.Boja = "crvena";
            a.ispisi();

            Vozilo v=new Vozilo();

            List<Vozilo> lista=new List<Vozilo>();
            lista.Add(v);
            lista.Add(a1);
            lista.Add(a);

            foreach(Vozilo vo in lista)
            {
                vo.ispisi();
            }

            Console.WriteLine(a);
            Console.WriteLine("Dusko Pilipovic");
            int br = 10;
            double d = br;
            Console.WriteLine("Unesi broj neki");
            string k;
            k=Console.ReadLine();
            Console.WriteLine(d+k+dani.pon);
        }
    }
}