namespace AbstractFactory.Abstract
{
    public interface IAbstractShip
    {
        string ShipUsefulFunction();

        string AnotherShipUsefulFunction(IAbstractCar car);
    }
}
