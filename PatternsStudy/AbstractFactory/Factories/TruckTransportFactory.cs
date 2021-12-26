using AbstractFactory.Abstract;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    class TruckTransportFactory : IAbstractTransportFactory
    {
        public IAbstractCar CreateCar()
        {
            return new CarTruck();
        }

        public IAbstractShip CreateShip()
        {
            return new ShipTruck();
        }
    }
}
