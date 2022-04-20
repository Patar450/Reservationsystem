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
            
            this.Show();
            this.WindowState = FormWindowState.Normal;
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
                string richtext = null;
                try
                {
                    richtext = string.Concat(rctxbxreview.Text.Where(char.IsLetterOrDigit));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please, ensure to type only letters and numbers, no special charaters.");
                }

                //Checks what is the next Id number.
                Con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Review_tbl", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                string savedata = dt1.Rows[0][0].ToString();
                int counter = 1 + Int32.Parse(savedata);
                SqlCommand cmd = new SqlCommand("insert into Review_tbl values('" + counter + "','" + txbxname.Text + "','" + richtext + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Review Successfully Added");
                Con.Close();

                ClientScreen clientScreen = new ClientScreen();
                clientScreen.Show();

                this.Hide();
            }
        }
    }
}
