using System;

namespace Klase
{
    public class Student : Person
    {
        public string Index { get; set; }

        public override void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Index} - {Name}");
        }
    }
}