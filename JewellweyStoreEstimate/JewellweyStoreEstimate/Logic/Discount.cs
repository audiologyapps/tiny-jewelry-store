using JewelleryStoreEstimate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    abstract class Discount :IDiscount
    {
        //Assuming the discount methods can be expanded for premium users and so on, making this as an abstract
        public virtual decimal GetDiscountRate()
        {
            return 0.00M;
        }
    }
}
