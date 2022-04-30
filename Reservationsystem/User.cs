using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservationsystem
{
    internal class User
    {
        //Creates a base class for User. For this version of the program not all attributes will be used in the amin program.
        //However they are created in case a new feature will be needed to be able to create a new User (Admin or not) from the admin page. 
        //In this version only the id,name,username,password,admin and locked will be used. The rest are all using the default values.
        private string id;
        private string name;
        private string surname;
        private string phone;
        private string dob;
        private string address;
        private string address2;
        private string postcode;
        private string country;
        private string email;
        private string username;
        private string password;
        private string admin;
        private string locked;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Admin
        {
            get { return admin; }
            set { admin = value; }
        }
        public string Locked
        {
            get { return locked; }
            set { locked = value; }
        }

        public User(string i, string nam, string sur, string pho,string dao, string addre,string addre2,string poco, string cou,string em,string use, string pass, string ad, string lk)
        {
            id = i;
            name = nam;
            surname = sur;
            phone = pho;
            dob = dao;
            address = ad;
            address2 = addre2;
            postcode = poco;
            country = cou;
            email = em;
            username = use;
            password = pass;
            admin = ad;
            locked = lk;
        }

        public User()
        {
            id = "blank";
            name = "blank";
            surname = "blank";
            phone = "blank";
            dob = "01/01/1990";
            address = "blank";
            address2 = "blank";
            country = "blank";
            postcode = "AAA000";
            email = "blank@blank.com";
            username = "blank";
            password = "blank";
            admin = "blank";
            locked = "No";
        }

        public virtual string loginattempts(string password)
        {
            if (password.ToLower().Equals(password.ToLower()))
            {
                return "No";
            }
            return "Yes";
        }
    }
}
