using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci
{
    enum VrstaGoriva {dizel,benzin };
    internal class Automobil
    {
        public string model {  get; set; }
        private string marka { get; set; }
        private string boja { get; set; }
        private int godina_proizvodnje {  get; set; }
        private VrstaGoriva vrsta_goriva { get; set; }
        private Motor motor = new Motor();

        public Automobil()
        {
            model = "Limuzina";
            marka = "Peugeot";
            boja = "siva";
            godina_proizvodnje = 2002;
            vrsta_goriva = VrstaGoriva.dizel;
            motor = new Motor();
        }

        public Automobil(string model, string marka, string boja, int godina_proizvodnje, VrstaGoriva vrsta_goriva, Motor motor)
        {
            this.model = model;
            this.marka = marka;
            this.boja = boja;
            this.godina_proizvodnje = godina_proizvodnje;
            this.vrsta_goriva = vrsta_goriva;
            this.motor = motor;
        }

        public override string ToString()
        {
            Console.WriteLine("-----Automobil--------");
            Console.WriteLine($"Model: {model}\nMarka: {marka}\nBoja: {boja}\nVrsta goriva: {vrsta_goriva}");
            Console.WriteLine($"Godina proizvodnje: {godina_proizvodnje}\n{motor}");
            return "";
        }
    }
}
