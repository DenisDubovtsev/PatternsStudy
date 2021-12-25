using Factory.Factories;
using System;

namespace Factory.Client
{
    public class LogisticCompany
    {
        public void StartWork()
        {
            Console.WriteLine("\nLaunched with the Car.");

            WorkFunction(new CarFactory());

            Console.WriteLine("\nLaunched with the Ship.");

            WorkFunction(new ShipFactory());
        }

        public void WorkFunction(TransportFactory factory)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + factory.WorkOperation());
        }
    }
}
