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
        public static class Global
        {
            public static string counter;
            public static string name;
            public static string lastname;
            public static string phone;
            public static string address;
            public static string country;
            public static string username;
            public static string password;
            public static string admin;
        }

        //Linking SQl Database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");


        //creating a class to organize the new acocunt details and add them to the Database.
     
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
            //Open connecttion to the Database
            conn.Open();

            //If statement to prompt user if the account entered matched the details stored in the Database.
            //Checks if the user name can be found as a Client.
            SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Client_tbl where Clientusername = '" + txtbxusernm.Text + "' and Clientpassword='" + txbxpasswrd.Text + "' and Admin='Admin'", conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                MainBooking frm = new MainBooking();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                SqlDataAdapter sda3 = new SqlDataAdapter("select COUNT(*) from Client_tbl where Clientusername = '" + txtbxusernm.Text + "' and Clientpassword='" + txbxpasswrd.Text + "'", conn);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);

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
                    Global.country = dt2.Rows[0][5].ToString();
                    Global.username = dt2.Rows[0][6].ToString();
                    Global.password = dt2.Rows[0][7].ToString();
                    Global.admin = dt2.Rows[0][8].ToString();

                    //if credentials are correct the login box will 'hide' and load the main form.
                    ClientScreen mf = new ClientScreen();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    //if credentials are incorrect the user will be prompt that one of the credentials are incorrect.
                    MessageBox.Show("Wrong Username or Password");
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
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
