using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Plane : ITransport
    {
        public string Model { get; set; }
        public string Speed { get; set; }
        public string Type { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Model} {Type} is flying at {Speed} km/h...");
        }
        public void FuelUp()
        {
            Console.WriteLine($"Refueling {Model}...");
        }
    }
}
