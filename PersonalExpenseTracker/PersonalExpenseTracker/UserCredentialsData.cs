using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    /*
     * This is the Entity class for user credentials details
     */
    public class UserCredentialsData
    {
        public String userName { get; set; }
        public String email { get; set; }
        public String nicNumber { get; set; }
        public String password { get; set; }
    }
}
