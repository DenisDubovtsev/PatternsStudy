using Factory.Abstract;
using Factory.Models;

namespace Factory.Factories
{
    public class ShipFactory : TransportFactory
    {
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }
}
