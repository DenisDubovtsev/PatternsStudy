using Factory.Abstract;

namespace Factory.Models
{
    public class Car : ITransport
    {
        public string Do()
        {
            return "Action of Car";
        }
    }
}
