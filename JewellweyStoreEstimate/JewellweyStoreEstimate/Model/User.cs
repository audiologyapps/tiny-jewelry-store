using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryStoreEstimate.Model
{
    public enum Categories { Regular, Privileged };
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Categories Category { get; set; }
        public User(string name , string password , Categories category)
        {
            this.UserName = name;
            this.Password = password;
            this.Category = category;
        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
