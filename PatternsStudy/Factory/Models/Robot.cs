﻿using Factory.Abstract;
using System;

namespace Factory.Models
{
    public class Robot : IMachine
    {
        public string Name
        {
            get { return "robot"; }
        }

        public void TurnOn()
        {
            Console.WriteLine("Robot is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Robot is stopping.");
        }
    }
}