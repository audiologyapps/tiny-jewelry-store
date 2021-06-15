using JewelleryStoreEstimate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    //considering as of now only system will print the message and it might print to various output factors
    class SystemPrinter : PrinterAbstraction
    {
        public override void Print()
        {
            MessagePrinter.PrintMessage(message);
        }
    }
}
