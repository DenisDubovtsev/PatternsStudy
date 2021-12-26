namespace AbstractFactory.Abstract
{
    public interface IAbstractTransportFactory
    {
        IAbstractCar CreateCar();
        IAbstractShip CreateShip();
    }
}
