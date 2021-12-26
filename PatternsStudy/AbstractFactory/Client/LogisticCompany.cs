using AbstractFactory.Abstract;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory.Client
{
    class LogisticCompany
    {
        public void StartWork()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new TruckTransportFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new SmallTransportFactory());
        }

        public void ClientMethod(IAbstractTransportFactory factory)
        {
            var car = factory.CreateCar();
            var ship = factory.CreateShip();

            Console.WriteLine(ship.ShipUsefulFunction());
            Console.WriteLine(ship.AnotherShipUsefulFunction(car));
        }
    }
}
