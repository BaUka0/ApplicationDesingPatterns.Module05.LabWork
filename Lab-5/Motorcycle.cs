using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Motorcycle : ITransport
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Model} is riding at {Speed} km/h...");
        }
        public void FuelUp()
        {
            Console.WriteLine($"Refueling {Model}...");
        }
    }
}
