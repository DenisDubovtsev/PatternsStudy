using AbstractFactory.Abstract;

namespace AbstractFactory.Models
{
    class ShipTruck : IAbstractShip
    {
        public string ShipUsefulFunction()
        {
            return "The result of the product ShipTruck.";
        }

        public string AnotherShipUsefulFunction(IAbstractCar car)
        {
            var result = car.CarUsefulFunction();

            return $"The result of the ShipTruck collaborating with the ({result})";
        }
    }

    class ShipSmall : IAbstractShip
    {
        public string ShipUsefulFunction()
        {
            return "The result of the product ShipSmall.";
        }

        public string AnotherShipUsefulFunction(IAbstractCar car)
        {
            var result = car.CarUsefulFunction();

            return $"The result of the ShipSmall collaborating with the ({result})";
        }
    }
}
