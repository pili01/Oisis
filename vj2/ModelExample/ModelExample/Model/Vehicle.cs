namespace ModelExample.Model
{
    class Vehicle
    {
        public string Name { get; init; }
        public int NumberOfWheels { get; private set; }

        public Vehicle(string name, int numberOfWheels)
        {
            Name = name;
            NumberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return $"| Name: {Name} | NumberOfWheels: {NumberOfWheels} |";
        }

        public static Vehicle CreateFromUserInput()
        {
            Console.WriteLine("Enter vehicle name: ");
            // ?? operator ce u name variablu smestiti string.Empty ("")
            // ukoliko je rezultat Console.ReadLine() null
            string name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter No. of wheels: ");
            // osiguravamo se da ulazni string ne bude null ili prazan string
            string wheelsString = Console.ReadLine() ?? "0";
            if (string.IsNullOrEmpty(wheelsString))
                wheelsString = "0";
            
            // osiguravamo se da ulazni string ne sadrzi slova
            int wheels;
            try
            {
                wheels = Convert.ToInt32(wheelsString);
            }
            catch (FormatException e) // ukoliko ulazni string sadrzi slova parsiranje ce baciti exception
            {
                // ovde smo mogli baciti drugi exception, ili ponovo traziti input od korsinika
                // zbog jednostavnosti primera, wheels stavljamo na 0
                wheels = 0;
            }

            Vehicle vehicle = new Vehicle(name, wheels);
            return vehicle;
        }
    }
}