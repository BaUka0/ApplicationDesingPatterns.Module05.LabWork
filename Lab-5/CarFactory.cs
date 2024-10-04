using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class CarFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            Console.WriteLine("Creating car:");
            Console.WriteLine("Enter car Brand:");
            string brand = Console.ReadLine();
            Console.Write("Enter car model: ");
            string model = Console.ReadLine();
            Console.Write("Enter car speed (km/h): ");
            int speed = int.Parse(Console.ReadLine());
            return new Car { Brand = brand, Model = model, Speed = speed };
        }
    }

}
