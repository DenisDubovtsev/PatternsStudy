using Factory.Abstract;

namespace Factory.Models
{
    public class UnknownMachine : IMachine
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }
    }
}
