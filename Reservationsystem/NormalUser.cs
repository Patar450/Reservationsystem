using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservationsystem
{
    internal class NormalUser:User
    {
        private int failedlogins;

        public int Failedlogins
        {
            get { return failedlogins; }
            set { failedlogins = value; }
        }

        public NormalUser(int flog)
        {
            failedlogins = flog;
        }

        public NormalUser()
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

                if (failedlogins == 5)
                {
                    MessageBox.Show("Your Account has been locked, please contact our customer service.");
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
