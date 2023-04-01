using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    interface IFuction
    {
        public void Scan();
        public void Copy();

    }
    interface IFax
    {
        public void Fax();
    }

    interface Icall
    {
        public void Call();
    }
}
