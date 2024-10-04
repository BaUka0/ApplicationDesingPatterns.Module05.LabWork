using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Car : ITransport
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Brand} {Model} is driving ar {Speed} km/h...");
        }
        public void FuelUp()
        {
            Console.WriteLine($"Refueling {Brand} {Model}");
        }
    }
}
