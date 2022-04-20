using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservationsystem
{
    internal class Admin: User
    {
        private int failedlogins;

        public int Failedlogins
        {
            get { return failedlogins; }
            set { failedlogins = value; }
        }

        public Admin(int flog)
        {
            failedlogins = flog;
        }

        public Admin()
        {
            failedlogins = 0;
        }
        public override string loginattempts(string password)
        {
            // The keyword base refers to the parent, so in our case the user class
            //return base.CheckPassword(pass);

            String ret;
            if (Locked == "Yes")
            {
                MessageBox.Show("This account is locked.");
                return "Yes";
            }

            ret = base.loginattempts(password);

            if (ret == "No")
            {
                failedlogins++;

                if (failedlogins == 3)
                {
                    MessageBox.Show("Your Account has been locked, please contact your line manager.");
                    return "Yes";
                }
                return "No";
            }
            else
            {
                failedlogins = 0;
                return "No";
            }
        }
    }
}
