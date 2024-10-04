using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class MotorcycleFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            Console.WriteLine("Creating motorcycle:");
            Console.Write("Enter motorcycle model: ");
            string model = Console.ReadLine();
            Console.Write("Enter motorcycle speed (km/h): ");
            int speed = int.Parse(Console.ReadLine());
            return new Motorcycle { Model = model, Speed = speed };
        }
    }
}
