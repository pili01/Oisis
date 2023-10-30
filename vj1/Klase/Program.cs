using System;

namespace Klase
{
    class Program
    {
        static void Main(string[] args)
        {
            Person annon = new Person();
            Console.WriteLine(annon);
            annon.SayHi();
            annon.Name = "Marko";
            annon.SayHi();

            Person marija = new Person("Marija");
            marija.SayHi();
            
            // Uraditi zadatak 2

            Student ra = new Student();
            ra.Name = "Nikola";
            ra.Index = "RA/XYZ";
            ra.SayHi();
        }
    }
}