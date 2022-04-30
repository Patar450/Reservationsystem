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
    public partial class Clientdetail : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");
        public Clientdetail()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clientdetail_Load(object sender, EventArgs e)
        {
            lblClientInformation.Text = Form1.Global.name + ", change details screen.";
            txbxfirstname.Text = Form1.Global.name;
            txbxlastname.Text = Form1.Global.lastname;
            txbxphone.Text = Form1.Global.phone;
            comboCountry.Text = Form1.Global.country;
            txbxusername.Text = Form1.Global.username;
            txbxpassword.Text = Form1.Global.password;
            txbxaddress.Text = Form1.Global.address;
            txbxaddress2.Text = Form1.Global.address2;
            txbxdob.Text = Form1.Global.dob;
            txbxemail.Text = Form1.Global.email;
            txbxpostcode.Text = Form1.Global.postcode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbxpassword.UseSystemPasswordChar == true)
            {
                txbxpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbxpassword.UseSystemPasswordChar = true;
            }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_tbl set ClientName = '" + txbxfirstname.Text + "', ClientSurname = '" + txbxlastname.Text + "', ClientPhone = '" + txbxphone.Text + "', ClientAddress ='" + txbxaddress.Text + "', ClientAddress2 ='" + txbxaddress2.Text + "', ClientCountry ='" + comboCountry.Text + "', ClientPostcode ='" + txbxpostcode.Text + "', Clientdateofbirth ='" + txbxdob.Text + "', ClientEmail ='" + txbxemail.Text + "', ClientUsername ='" + txbxusername.Text + "', ClientPassword ='" + txbxpassword.Text + "' where ClientId = '" + Form1.Global.counter + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited. Please log out and log back in see the change.");
            Con.Close();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblClientInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
