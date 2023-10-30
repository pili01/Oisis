using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba
{
    public class Vozilo
    {
        protected string boja;
        public int prosjecna_brzina { get;set; }

        public virtual void ispisi()
        {
            Console.WriteLine("Vozilo\n" + "Boja: ", boja?.ToUpper() + "\nBrzina " + prosjecna_brzina);
        }
    }
}
