using Singleton.Singleton;
using System;

namespace Singleton
{       
    class Program
    {
        static void Main(string[] args)
        {            
            var s1 = SingletonClass.GetInstance();
            var s2 = SingletonClass.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
