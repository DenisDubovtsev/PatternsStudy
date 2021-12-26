using AbstractFactory.Abstract;

namespace AbstractFactory.Models
{
    class CarTruck : IAbstractCar
    {
        public string CarUsefulFunction()
        {
            return "The result of the product CarTruck.";
        }
    }

    class CarSmall : IAbstractCar
    {
        public string CarUsefulFunction()
        {
            return "The result of the product CarSmall.";
        }
    }
}
