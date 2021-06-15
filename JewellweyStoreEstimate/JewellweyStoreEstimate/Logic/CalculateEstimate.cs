using JewelleryStoreEstimate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    // This is an abstract class which can support future extension for different other metals like silver/platinum 
    // that can invlove a different calculation process 
    public abstract class CalculateEstimate
    {
        public decimal GoldPrice { get; set; }
        public decimal Weight { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public User user { get; set; }
        public List<User> users = new List<User>();
        public abstract void GetUserInputs();
        public abstract void SetDiscount();
        public abstract void CalculateEstimation();
        public abstract void PrintEstimation();
        public abstract void GetUser();
        public abstract void ValidateUser();
        public abstract void CreateSampleUsers();
    }
}
