using AbstractFactory.Abstract;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    class SmallTransportFactory : IAbstractTransportFactory
    {
        public IAbstractCar CreateCar()
        {
            return new CarSmall();
        }

        public IAbstractShip CreateShip()
        {
            return new ShipSmall();
        }
    }
}
