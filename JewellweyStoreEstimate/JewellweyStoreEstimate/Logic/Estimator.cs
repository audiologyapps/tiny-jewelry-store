using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    public class Estimator
    {
        public void CalculateRate(CalculateEstimate calculateEstimate)
        {
            //Method to create 2 sample users with Regular and Priviledged
            calculateEstimate.CreateSampleUsers();

            //Method to get user name and password from console
            calculateEstimate.GetUser();

            //Method to validate the user name and password against the existing user
            calculateEstimate.ValidateUser();

            //Method to get the other inputs as gold rate ans weight
            calculateEstimate.GetUserInputs();

            //Method to assign Discount value as per category
            calculateEstimate.SetDiscount();

            //Method to calculate the total price
            calculateEstimate.CalculateEstimation();

            //Method to print the output either to Screen, file or to printer
            calculateEstimate.PrintEstimation();
        }
    }
}
