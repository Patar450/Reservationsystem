using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservationsystem
{
    internal class User
    {
        //Attributes
        private string firstname;
        private string lastname;
        private string phone;
        private string country;
        private string username;
        private string password;
        


        //Getters & Setters
        public string Firstname
        { get { return firstname; } set { firstname = value; } }

        public string Lastname
        { get { return lastname; } set  { lastname = value;  } }

        public string Phone
        { get { return phone; } set { phone = value; } }

        public string Country
        { get { return country; } set { country = value; } }
        public string Username
        { get { return username; } set { username = value; } }

        public string passwordHash
        {
            get { return password; }
            set { password = value; }
        }

        // Check Password
        public virtual bool CheckPassword(string pass)
        {
            if (pass.ToLower().Equals(password.ToLower()))
            {
                return true;
            }
            return false;
        }
    }
}
