using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    class HP1500 : IFax, Icall,IFuction
    {
        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void Copy()
        {
            Console.WriteLine("Copying..");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning..");
        }

        public void Fax()
        {
            Console.WriteLine("Fax....");
        }

      
    }

    class HP1900 : IFuction
    {
        public void Copy()
        {
            Console.WriteLine("Copying..");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning..");
        }
    }

}
