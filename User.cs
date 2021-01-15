using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management
{
    public class User
    {
        public string username{ get; }
        public string type{ get; } //Director or Project Manager
        public string email{ get; }
        public string password{ get; }
        public User(string uname, string typ, string mail, string pas)
        {
            this.username = uname;
            this.type = typ;
            this.email = mail;
            this.password = pas;
        }
    }
}
