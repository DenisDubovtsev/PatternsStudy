using Factory.Client;
using Factory.Factories;
using System;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BasicFactory();
            FactoryWithReflection();
        }
        
        public static void BasicFactory()
        {
            Console.WriteLine("First factory variant, basic structure: ");

            new LogisticCompany().StartWork();

            Console.WriteLine();
        }
        
        public static void FactoryWithReflection()
        {
            Console.WriteLine("Second factory variant, with reflection:\n ");
            
            //string description = "truck";
            var machineType = "robot";

            var machine = new MachineFactory().CreateInstance(machineType);

            machine.TurnOn();
            machine.TurnOff();
        }
    }
}
