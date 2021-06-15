using JewelleryStoreEstimate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    //discount for Regular user
    class RegularDiscount : IDiscount
    {
        public decimal GetDiscountRate()
        {
            return 0.0M;
        }
    }
}
