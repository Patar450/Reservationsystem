using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Reservationsystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //Linking SQl Database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        // Variables to store temp account details to store them in an Object and use the methods in the classes as a security filtering system.  
        // These variables are used in lines: 57 - 73, 82 & 103  
        public static string firstname;
        public static string lastname;
        public static string phonenumber;
        public static string address;
        public static string country;
        public static string username;
        public static string password;
        public static string admin;
        public static string locked;
        

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear buttton: clear all textboxess and a combo box.
            txbxfirstname.Clear();
            txbxlastname.Clear();
            txbxpassword.Clear();
            txbxphone.Clear();
            txbxusername.Clear();
            comboCountry.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Back button in case the user clicked Register by Mistake. This will take the user back to the login page
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Here all the txtboxex values are stored in the Variables mentioned in line 24
            firstname = txbxfirstname.Text;
            lastname = txbxlastname.Text;
            phonenumber = txbxphone.Text;
            address = txbxaddress.Text;
            country = comboCountry.SelectedItem.ToString();
            username = txbxusername.Text;
            password = txbxpassword.Text;
            locked = "No";

            if (chbxadmin.Checked == true)
            {
                admin = "Admin";
            }
            else
            {
                admin = "User";
            }
            //Open connecttion to the Database
            conn.Open();

            //Checks if the user name can be found as a staff.
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Client_tbl where ClientUsername = '" + txbxusername.Text + "' and Clientpassword='" + txbxpassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //If statement to check if all textboxes are filled in.
            if (firstname == null || lastname == null || phonenumber == null || address == null || country == null || username == null || password == null)
            {
                MessageBox.Show("Please fill in all the boxes.");
            }
            //If statement to prompt user if the account entered matched the details stored in the Database.
            else if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("This user is already taken.");
                return;
            }
            else
            {
                
                //Checks what is the next Id number and automatically add the ID to the database.
                SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Client_tbl ", conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                string savedata = dt1.Rows[0][0].ToString();
                int counter = 1 + Int32.Parse(savedata);
                SqlCommand cmd = new SqlCommand("insert into Client_tbl values('" + counter + "','" + firstname + "','" + lastname + "','" + phonenumber + "','" +address+ "','"+ country + "','" + username + "','" + password +"','"+admin+"','"+locked+ "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration complete. Returning to login form.");
                conn.Close();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            //Closes Database connection
            conn.Close();
        }

        private void txbxphone_TextChanged(object sender, EventArgs e)
        {
            //Input control to limit the textbox to only accepts numbers
            txbxphone.Text = string.Concat(txbxphone.Text.Where(char.IsNumber));
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //Restrics user to manually type.
            comboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txbxfirstname_TextChanged(object sender, EventArgs e)
        {
            //Input control to limit the textbox to only accepts Letters
            txbxfirstname.Text = string.Concat(txbxfirstname.Text.Where(char.IsLetter));
        }

        private void txbxlastname_TextChanged(object sender, EventArgs e)
        {
            //Input control to limit the textbox to only accepts Letters
            txbxlastname.Text = string.Concat(txbxlastname.Text.Where(char.IsLetter));
        }

        private void txbxusername_TextChanged(object sender, EventArgs e)
        {
            //Input control to limit the textbox to not accept special characters
            txbxusername.Text = string.Concat(txbxusername.Text.Where(char.IsLetterOrDigit));
        }

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbxadmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
