using Factory.Abstract;
using System;

namespace Factory.Models
{
    public class Truck : IMachine
    {
        public string Name
        {
            get { return "truck"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Car is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}
