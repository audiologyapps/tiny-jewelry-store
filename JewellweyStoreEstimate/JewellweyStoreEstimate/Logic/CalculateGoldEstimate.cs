using JewelleryStoreEstimate.Interface;
using JewelleryStoreEstimate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Logic
{
    class CalculateGoldEstimate : CalculateEstimate
    {

        //Method that creates 2 sample users
        public override void CreateSampleUsers()
        {
            users.Add(new User("Siemens1", "Password-1", Categories.Regular));
            users.Add(new User("Siemens2", "Password-2", Categories.Privileged));
        }

        //Method to get input from console
        public override void GetUser()
        {
            Console.WriteLine("Please enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter Password");
            string password = Console.ReadLine();
            user = new User(userName, password);
        }

        //Method to validate user name and password
        public override void ValidateUser()
        {
            user = users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if (user == null)
            {
                Console.WriteLine("UserName / Password entered is incorrect");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        //Method to get other gold related inputs
        public override void GetUserInputs()
        {
            Console.WriteLine("*********************       Welcome " + user.Category+" user        **********************");
            Console.WriteLine("Please Enter Gold Price(Per Gram)");
            GoldPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Weight(Grams)");
            Weight = decimal.Parse(Console.ReadLine());
        }

        //Method to set discount based on category
        public override void SetDiscount()
        {
            IDiscount discount;
            if (user.Category == Categories.Regular)
                discount = new RegularDiscount();
            else
                discount = new PriviledgedDiscount();

            Discount = discount.GetDiscountRate();
        }

        //Method to calculate the total price estimate of gold with the input provided
        public override void CalculateEstimation()
        {
            var price = GoldPrice * Weight;
            TotalPrice = (price - (price * Discount) / 100);
        }

        //Method to print output based on users preference. Switch can be eliminated when the actions are kept as buttons in the UI
        public override void PrintEstimation()
        {
            Console.WriteLine("Please select the Printing Option as 1,2,3 or 4 \n1.Calculate\n2.ToScreen\n3.ToFile\n4.ToPrinter");
            int value = int.Parse(Console.ReadLine());
            string Message = "The total Price of the gold is :" + TotalPrice;

            SystemPrinter printer = new SystemPrinter();
            printer.message = Message;

            switch (value)
            {
                case 1:
                    {
                        Console.WriteLine(TotalPrice);
                        break;
                    }
                case 2:
                    {
                        IPrintMessage print = new OnScreenPrinting();
                        printer.MessagePrinter = print;
                        printer.Print();
                        break;
                    }
                case 3:
                    {
                        IPrintMessage print = new FilePrinting();
                        printer.MessagePrinter = print;
                        printer.Print();
                        break;
                    }
                case 4:
                    {
                        IPrintMessage print = new Printer();
                        printer.MessagePrinter = print;
                        printer.Print();
                        break;
                    }
            }
        }
    }
}
