using JewelleryStoreEstimate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    //An abstraction of printer, suppose in future if a new derivative is required to print system message, user message or a message from API
    abstract class PrinterAbstraction
    {
        public IPrintMessage MessagePrinter { get; set; }
        public string message { get; set; }
        public abstract void Print();
    }
}
