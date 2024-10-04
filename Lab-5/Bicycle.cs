using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Bicycle : ITransport
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Model} is riding at {Speed} km/h...");
        }

        public void FuelUp()
        {
            Console.WriteLine("No refueling required for a bicycle.");
        }
    }
}
