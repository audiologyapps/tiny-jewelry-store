using JewelleryStoreEstimate.Interface;

namespace JewelleryStoreEstimate.Logic
{
    class PriviledgedDiscount : IDiscount
    {
        //Discount for priviledged user
        public decimal GetDiscountRate()
        {
            return 2.0M;
        }
    }
}
