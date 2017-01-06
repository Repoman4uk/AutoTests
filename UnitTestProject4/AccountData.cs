using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class AccountData
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public AccountData(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
