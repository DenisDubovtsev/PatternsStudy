﻿using Factory.Abstract;
using System;

namespace Factory.Models
{
    public class MicrowaveOven : IMachine
    {
        public string Name
        {
            get { return "microwave oven"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Microwave oven is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Microwave oven is stopping.");
        }
    }
}
