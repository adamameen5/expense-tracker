using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    /*
     * This is the Entity class for user details
     */
    public class UserDetails
    {
        public String userName { get; set; }
        public String email { get; set; }
        public String nicNumber { get; set; }
        public String password { get; set; }

        public String fullName { get; set; }
        public String contact { get; set; }
        public String address { get; set; }
        public String recoveryEmailAddress { get; set; }
        public String dateOfBirth { get; set; }
    }
}
