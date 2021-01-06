using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management
{
    enum UserType {
        Director,
        ProjectManager
    }
    class User
    {
        private string username;
        private string type; //Director or ProjectManager
        private string email;
        private string password;
    }
}
