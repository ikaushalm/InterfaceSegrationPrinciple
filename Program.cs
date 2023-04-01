using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            HP1500 H15 = new HP1500();
            H15.Copy();
            H15.Call();
            Console.ReadKey();

        }
    }
}
