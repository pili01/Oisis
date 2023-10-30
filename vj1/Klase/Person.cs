using System;

namespace Klase
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int Age { get; set; }

        public Person()
        {
            Name = "Anonymous";
        }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
        
        // zadatak 2. Dodati metodu za ispis godina na konzoli i pozvati je na odgovarajućem mestu

    }
}   