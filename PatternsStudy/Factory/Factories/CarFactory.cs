using Factory.Abstract;
using Factory.Models;

namespace Factory.Factories
{
    public class CarFactory : TransportFactory
    {
        public override ITransport FactoryMethod()
        {
            return new Car();
        }
    }
}
