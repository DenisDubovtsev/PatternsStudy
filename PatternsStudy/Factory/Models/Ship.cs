using Factory.Abstract;

namespace Factory.Models
{
    public class Ship : ITransport
    {
        public string Do()
        {
            return "Action of Ship";
        }
    }
}
