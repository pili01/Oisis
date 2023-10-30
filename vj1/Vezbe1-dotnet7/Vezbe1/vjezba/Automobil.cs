using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba
{
    class Automobil:Vozilo
    {
        private string marka="audi";
         public override void ispisi()
        {
            Console.WriteLine($"Automobil\n Boja: {boja?.ToUpper()} \n Brzina { prosjecna_brzina} marka: {marka}");
        }

        public string Boja
        {
            get { return boja; }
            set { boja = value; }
        }


        public Automobil(string b)
        {
            boja = b;
        }

        public Automobil() {
            prosjecna_brzina = 100;
        }  
    }
}
