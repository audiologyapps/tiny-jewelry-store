using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Interface
{
    //interface to print message to avoid concrete implementation of methods
    interface IPrintMessage
    {
        void PrintMessage(string message);
    }
}
