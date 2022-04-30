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
    public partial class MyOrders : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\OneDrive\Documents\School\STC School - Diploma\DDOOCP - Designing and Developing Object-Oriented Computer Programs (21 22) - FT - General\Assigment\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");
        //DateTime res and res1 are used for Dates
        DateTime today;
        private int res;
        private int res1;

        private bool alert = false;
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Reservation_tbl where Client ='"+Form1.Global.name+ "';";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Reservation_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public MyOrders()
        {
            InitializeComponent();
        }

        private void Reservation_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbxReservationID.Text = Reservation_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txbxname.Text = Reservation_GridView.SelectedRows[0].Cells[1].Value.ToString();
            txbxBoatname.Text = Reservation_GridView.SelectedRows[0].Cells[2].Value.ToString();
            Datein.Text = Reservation_GridView.SelectedRows[0].Cells[3].Value.ToString();
            Dateout.Text = Reservation_GridView.SelectedRows[0].Cells[4].Value.ToString();
            txbxaddress.Text = Reservation_GridView.SelectedRows[0].Cells[5].Value.ToString();
            txbxphone.Text = Reservation_GridView.SelectedRows[0].Cells[6].Value.ToString();
            txbxpricetotal.Text = Reservation_GridView.SelectedRows[0].Cells[7].Value.ToString();
            txbxprice.Text = Reservation_GridView.SelectedRows[0].Cells[8].Value.ToString();
            alert = true;
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            // grabs the date today and stor it in today.
            today = Datein.Value;


            //Converts the date into a long format: hh:mm:ss
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
            //when form starts enable timer.
            timer1.Start();
            //Loads Method called populate.
            populate();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txbxReservationID.Text == "")
            {
                MessageBox.Show("Please, Choose an order to edit.");
            }
            else
            {
                Datein.Enabled = true;
                Dateout.Enabled = true;
                btn_Edit.Enabled = false;
                btn_lock.Enabled = true;
            }
            
        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
            res = DateTime.Compare(Datein.Value, today);
            if (alert == true)
            {
                if (res < 1)
                {
                    MessageBox.Show("Please, pick a future date.");
                    btn_lock.Enabled = false;
                }
            }
            
        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
            if (alert == true)
            {
                res = DateTime.Compare(Dateout.Value, today);
                res1 = DateTime.Compare(Dateout.Value, Datein.Value);
                if (res1 > -1)
                {
                    btn_lock.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please, pick a future date.");
                    btn_lock.Enabled = false;
                }
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            //Edits text from the Reservation table.
            Con.Open();
            string myquery = "UPDATE Reservation_tbl set DateIn = '"+Datein.Text+"', DateOut='"+Dateout.Text+"',TotalPrice='"+txbxpricetotal.Text+"' where ReservationId = '" + txbxReservationID.Text + "';";
            SqlCommand cmd1 = new SqlCommand(myquery, Con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Boat Successfully Booked");
            Con.Close();
            populate();
            btnconfirm.Enabled = false;
            btn_Edit.Enabled=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datein.Enabled = false;
            Dateout.Enabled = false;
            btn_lock.Enabled = false;
            int totalpriceincludingdate = Convert.ToInt32(txbxprice.Text);
            var numberofdays = (Dateout.Value - Datein.Value).Days;
            int num = Convert.ToInt32(numberofdays);
            int totalpricez;
            totalpricez = num * totalpriceincludingdate;
            txbxpricetotal.Text = Convert.ToString(totalpricez);
            btnconfirm.Enabled = true;
            MessageBox.Show("Total price is now: " + totalpricez);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txbxReservationID.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be deleted.");
            }
            else
            {
                Con.Open();
                string query = "delete from Reservation_tbl where ReservationId = " + txbxReservationID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted");
                Con.Close();

                Con.Open();
                string query1 = "UPDATE Boat_tbl set Availability = 'Yes' where BoatName = '" + txbxBoatname.Text + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
                Con.Close();
                populate();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ClientScreen clientScreen = new ClientScreen();
            clientScreen.Show();
        }
    }
}
