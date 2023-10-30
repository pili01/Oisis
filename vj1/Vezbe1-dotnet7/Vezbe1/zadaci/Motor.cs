using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci
{
    internal class Motor
    {
        public string naziv {  get; set; }
        public double kubikaza {  get; set; }
        public int snaga {  get; set; }

        public Motor()
        {
            naziv = "Sus";
            kubikaza = 2.0;
            snaga = 75;
        }

        public Motor(string naziv, double kubikaža, int snaga)
        {
            this.naziv = naziv;
            this.kubikaza = kubikaža;
            this.snaga = snaga;
        }

        public override string ToString() {
            Console.WriteLine("-----Motor--------");
            Console.WriteLine($"Naziv: {naziv}\nKubikaza: {kubikaza}\nSnaga:{snaga}");
            return "";
        }

        public override bool Equals(Object? o)
        {
            Motor obj=(Motor)o;
            if (obj == null) return false;
            if (obj.naziv.Equals(this.naziv) && obj.kubikaza == this.kubikaza && obj.snaga == this.snaga) { return true; }
            else return false;
            return base.Equals(obj);
        }
    }

   
}
