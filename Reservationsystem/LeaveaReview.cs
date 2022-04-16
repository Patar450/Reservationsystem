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
    public partial class LeaveaReview : Form
    {
        public LeaveaReview()
        {
            InitializeComponent();
        }

        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        private void rctxbxreview_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveaReview_Load(object sender, EventArgs e)
        {
            txbxname.Text = Form1.Global.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClientScreen clientScreen = new ClientScreen();
            clientScreen.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rctxbxreview.Text == null)
            {
                MessageBox.Show("Please,don't submit an empty review");
            }
            else
            {
                //Checks what is the next Id number.
                Con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Reservation_tbl ", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                string savedata = dt1.Rows[0][0].ToString();
                int counter = 1 + Int32.Parse(savedata);
                Con.Close();

                string richtext = rctxbxreview.Text;
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Review_tbl values('" + counter + "','" + txbxname.Text + "','" + richtext + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Added");
                Con.Close();

                ClientScreen clientScreen = new ClientScreen();
                clientScreen.Show();

                this.Hide();
            }
        }
    }
}
