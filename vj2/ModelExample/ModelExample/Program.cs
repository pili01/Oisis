using ModelExample.Model;

namespace ModelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = Vehicle.CreateFromUserInput();
            Console.WriteLine(vehicle);
            Console.WriteLine("Dusko Pilipovic");
            Console.ReadKey();
        }
    }
}