using Factory.Abstract;

namespace Factory.Factories
{
    public abstract class TransportFactory
    {
        public abstract ITransport FactoryMethod();

        public string WorkOperation()
        {
            var transport = FactoryMethod();

            var result = "Creator: The same creator's code has just worked with " + transport.Do();

            return result;
        }
    }
}
