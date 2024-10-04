using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class BicycleFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            Console.WriteLine("Creating bicycle:");
            Console.Write("Enter bicycle model: ");
            string model = Console.ReadLine();
            Console.Write("Enter bicycle speed (km/h): ");
            int speed = int.Parse(Console.ReadLine());
            return new Bicycle { Model = model, Speed = speed };
        }
    }

