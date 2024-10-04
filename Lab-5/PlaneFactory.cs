using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class PlaneFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            Console.WriteLine("Creating plane:");
            Console.Write("Enter plane model: ");
            string model = Console.ReadLine();
            Console.Write("Enter plane speed (km/h): ");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter type:");
            string type = Console.ReadLine();
            return new Plane { Model = model, Speed = speed, Type = type };
        }
    }
}
