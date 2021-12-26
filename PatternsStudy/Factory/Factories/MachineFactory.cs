using Factory.Abstract;
using Factory.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Factory.Factories
{
    public class MachineFactory
    {
        Dictionary<string, Type> _machineTypes = new Dictionary<string, Type>();

        public MachineFactory()
        {
            LoadTypesICanReturn();
        }

        public IMachine CreateInstance(string machineType)
        {
            Type t = GetTypeToCreate(machineType);

            if (t == null)
                return new UnknownMachine();

            return Activator.CreateInstance(t) as IMachine;
        }

        private Type GetTypeToCreate(string machineName)
        {
            foreach (var machine in _machineTypes)
            {
                if (machine.Key.Contains(machineName))
                {
                    return _machineTypes[machine.Key];
                }
            }

            return null;
        }

        private void LoadTypesICanReturn()
        {
            //_machineTypes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IMachine).ToString()) != null)
                {
                    _machineTypes.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
