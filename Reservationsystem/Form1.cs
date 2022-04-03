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
        //Linking SQl Database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

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
            //Checks if the user name can be found as a staff.
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Staff_tbl where Staffusername = '"+ txtbxusernm.Text + "' and Staffpassword='"+ txbxpasswrd.Text+ "'",conn);
            DataTable dt=new DataTable();
            sda.Fill(dt);

            //If statement to prompt user if the account entered matched the details stored in the Database.
            if (dt.Rows[0][0].ToString() == "1")
            {
                //if credentials are correct the login box will 'hide' and load the main form.
                MainBooking mf = new MainBooking();
                mf.Show();
                this.Hide();
            }
            else 
            {
                //if credentials are incorrect the user will be prompt that one of the credentials are incorrect.
                MessageBox.Show("Wrong Username or Password");
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
    }
}
