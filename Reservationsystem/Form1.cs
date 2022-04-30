using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Reservationsystem
{
    public partial class Form1 : Form
    {
        //Creates a new instance of the object, called userAdmin & NormalUser
        List<User> account = new List<User>();
        User Adminuser = new Admin();
        User Normaluser = new NormalUser();

        //Method to control if the username belong to an admin or not. Creates an Object and then checks how many logins have been attempted
        private void AddtempAccount()
        {
            if (admin == "Admin")
            {
                Adminuser.Id = counter;
                Adminuser.Username = username;
                Adminuser.Password = password;
                Adminuser.Locked = locked;
                account.Add(Adminuser);
            }
            else if(admin == "User")
            {
                Normaluser.Id = counter;
                Normaluser.Username = username;
                Normaluser.Password = password;
                Normaluser.Locked = locked;
                account.Add(Normaluser);
            }
        }
        //Global variables to get when the login is successful of a normal user.
        public static class Global
        {
            public static string counter;
            public static string name;
            public static string lastname;
            public static string phone;
            public static string address;
            public static string address2;
            public static string country;
            public static string postcode;
            public static string dob;
            public static string email;
            public static string username;
            public static string password;
            public static string locked;
        }

        //Login Checkers by creating an object using the variables below
        public static string counter;
        public static string username;
        public static string admin;
        public static string password;
        public static string password2;
        public static string locked;

        //Linking SQl Database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\OneDrive\Documents\School\STC School - Diploma\DDOOCP - Designing and Developing Object-Oriented Computer Programs (21 22) - FT - General\Assigment\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        private void accountlocker(string password2)
        {
            if (admin == "User")
            {
                if (password2 == "Yes")
                {
                    string myquery = "UPDATE Client_tbl set Locked = 'Yes' where ClientUsername = '" + txtbxusernm.Text + "';";
                    SqlCommand cmd1 = new SqlCommand(myquery, conn);
                    cmd1.ExecuteNonQuery();
                }
            }
            else if (admin == "Admin")
            {
                if (password2 == "Yes")
                {
                    string myquery = "UPDATE Admin_tbl set Locked = 'Yes' where AdminUsername = '" + txtbxusernm.Text + "';";
                    SqlCommand cmd1 = new SqlCommand(myquery, conn);
                    cmd1.ExecuteNonQuery();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtbxusernm_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Open connection to the Database
            conn.Open();
            //Database query to check if the username entered is in the system without checking if the password entered was correct.
            SqlDataAdapter sda7 = new SqlDataAdapter("select COUNT(*) from Admin_tbl where AdminUsername = '" + txtbxusernm.Text + "'", conn);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            //if the result of above query came up with 1, the following if statement gets executed.
            if (dt7.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda70 = new SqlDataAdapter("select COUNT(*) from Admin_tbl where AdminUsername = '" + txtbxusernm.Text + "' and Locked = 'Yes'", conn);
                DataTable dt70 = new DataTable();
                sda70.Fill(dt70);

                if (dt70.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("This account is locked please contact your line manager.");
                }
                else
                {
                    //Another query to now check if the password entered exists.
                    SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Admin_tbl where AdminUsername = '" + txtbxusernm.Text + "' and AdminPassword='" + txbxpasswrd.Text + "'", conn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    //If the result is 0. That means that the username and password for the admin was incorrect
                    if (dt1.Rows[0][0].ToString() == "0")
                    {
                        //Since the login process was wrong. An object is created and gives the user 2 more tries before the account is locked.
                        SqlDataAdapter sda11 = new SqlDataAdapter("select * from Admin_tbl where AdminUsername = '" + txtbxusernm.Text + "' ", conn);
                        DataTable dt11 = new DataTable();
                        sda11.Fill(dt11);
                        counter = dt11.Rows[0][0].ToString();
                        username = dt11.Rows[0][10].ToString();
                        password = dt11.Rows[0][11].ToString();
                        admin = "Admin";
                        locked = dt11.Rows[0][12].ToString();

                        //Method to create an object. See line: 24
                        AddtempAccount();

                        //Method that is stored in a Child Class Admin.cs.
                        string password2 = Adminuser.loginattempts(account.ElementAt(0).Password);

                        //If the result of Method in line 122 is 'Yes' the database will update itself and lock the account using the below method. Full code on line: 70
                        accountlocker(password2);
                    }
                    //if however both username and password was correct and Admin is true. Then the Admin Form will load. 
                    else if (dt1.Rows[0][0].ToString() == "1")
                    {
                        MainBooking frm = new MainBooking();
                        frm.ShowDialog();
                        this.Hide();
                    }
                }
                
            }
            //Since the database to check if user is admin came with the result of 0. Now the code will check if the credentials belong to a normal user.
            else
            {
                //Query to check if user (not admin) exists in the database.
                SqlDataAdapter sda4 = new SqlDataAdapter("select COUNT(*) from Client_tbl where Clientusername = '" + txtbxusernm.Text + "'", conn);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                //if user name exists the following if statement will commence. 
                if (dt4.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sda40 = new SqlDataAdapter("select COUNT(*) from Client_tbl where Clientusername = '" + txtbxusernm.Text + "' and Locked ='Yes'", conn);
                    DataTable dt40 = new DataTable();
                    sda40.Fill(dt40);

                    if(dt40.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("This account is locked please contact our customer care on: +999 1234 5678");
                    }
                    else
                    {
                        //Now it'll check if the password matches with what we have in our database. 
                        SqlDataAdapter sda3 = new SqlDataAdapter("select COUNT(*) from Client_tbl where Clientusername = '" + txtbxusernm.Text + "' and Clientpassword='" + txbxpasswrd.Text + "'", conn);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);

                        //If both credentials are correct the cleint information is stored in the global variables to be able to identify the user throughout his journey. 
                        //Line: 45 - Global Variables.
                        if (dt3.Rows[0][0].ToString() == "1")
                        {
                            //Grabs the name from the database to show is on the welcome sign in form ClienScreen.
                            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Client_tbl where Clientusername = '" + txtbxusernm.Text + "' and Clientpassword='" + txbxpasswrd.Text + "'", conn);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);

                            Global.counter = dt2.Rows[0][0].ToString();
                            Global.name = dt2.Rows[0][1].ToString();
                            Global.lastname = dt2.Rows[0][2].ToString();
                            Global.phone = dt2.Rows[0][3].ToString();
                            Global.address = dt2.Rows[0][4].ToString();
                            Global.address2 = dt2.Rows[0][5].ToString();
                            Global.country = dt2.Rows[0][6].ToString();
                            Global.postcode = dt2.Rows[0][7].ToString();
                            Global.dob = dt2.Rows[0][8].ToString();
                            Global.email = dt2.Rows[0][9].ToString();
                            Global.username = dt2.Rows[0][10].ToString();
                            Global.password = dt2.Rows[0][11].ToString();

                            //Login box will 'hide' and load the main form.
                            ClientScreen mf = new ClientScreen();
                            mf.Show();
                            this.Hide();
                        }
                        // if the user is found but password is incorrect than an object is created and will give the user up to 5 attempts before that account is locked.
                        else if (dt3.Rows[0][0].ToString() == "0")
                        {
                            SqlDataAdapter sda11 = new SqlDataAdapter("select * from Client_tbl where Clientusername = '" + txtbxusernm.Text + "' ", conn);
                            DataTable dt11 = new DataTable();
                            sda11.Fill(dt11);
                            counter = dt11.Rows[0][0].ToString();
                            username = dt11.Rows[0][10].ToString();
                            password = dt11.Rows[0][11].ToString();
                            admin = "User";
                            locked = dt11.Rows[0][12].ToString();
                            AddtempAccount();

                            string password2 = Normaluser.loginattempts(account.ElementAt(0).Password);
                            //If the result of Method in line 122 is 'Yes' the databse will update itself and lock the account using the below method. Full code on line: 70
                            accountlocker(password2);
                        }
                    }
                    
                }

                else
                {
                    //if credentials are incorrect the user will be prompt that one of the credentials are incorrect.
                    MessageBox.Show("Username doesn't exist");
                }
            }

            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Image Obtined from: https://www.flaticon.com/free-icons/username Username icons created by Freepik - Flaticon
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Image Obtained from:https://www.flaticon.com/free-icons/password Password icons created by Freepik - Flaticon
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If the register button is click. This form will be hidden and the Register Form will load.
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
