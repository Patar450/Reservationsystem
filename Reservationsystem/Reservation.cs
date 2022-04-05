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
    public partial class Reservation : Form
    {

        //Establishes a connection to the SQL Database.
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        DateTime today;
        private int res;

        //loads the Client data from the database into the grid view
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Reservation_GridView.DataSource = ds.Tables[0];
            Con.Close();

        }
        public Reservation()
        {
            InitializeComponent();
        }
        //method to fill the combo boxes
        private void fillBoatcombo()
        {
            Con.Open();
            string boatstate = "Free";
            SqlCommand cmd = new SqlCommand("Select BoatName from Boat_tbl where BoatFree = '"+boatstate+"'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BoatName",typeof(string));
            dt.Load(rdr);
            ComboBoat.ValueMember = "BoatName";
            ComboBoat.DataSource = dt;
            Con.Close();
        }

        private void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            ComboClient.ValueMember = "ClientName";
            ComboClient.DataSource = dt;
            Con.Close();
        }
        //updates the boat that is added to the busy list.
        public void updatereservations()
        {
            Con.Open();
            string remove = "Busy";
            string myquery = "UPDATE Boat_tbl set BoatFree = '" +remove+ "' where BoatName = '" +ComboBoat.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            fillBoatcombo();
        }

        public void deletereservations()
        {
            Con.Open();
            string remove = "Free";
            string BoatName = Reservation_GridView.SelectedRows[0].Cells[2].Value.ToString();
            string myquery = "UPDATE Boat_tbl set BoatFree = '" + remove + "' where BoatName = '" + BoatName + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            fillBoatcombo();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values('" + txbxReservationID.Text + "','" + ComboClient.SelectedValue.ToString() + "','" + ComboBoat.SelectedValue.ToString() + "','"  +Datein.Text + "','" +Dateout.Text+ "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            updatereservations();
            populate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txbxReservationID.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be edited.");
            }
            else
            {
                //Edits text from the Reservation_tbl.
                Con.Open();
                string myquery = "UPDATE Reservation_tbl set Client = '" + ComboClient.SelectedValue.ToString() + "', Boat = '" + ComboBoat.SelectedValue.ToString() + "', DateIn = '" + Datein.Value + "', DateOut =' " + Dateout.Value + "' where ReservationId = '" + txbxReservationID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client Successfully Edited");
                Con.Close();
                populate();
            }
            
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
                deletereservations();
                populate();
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // grabs the date today and stor it in today.
            today = Datein.Value;


            //Converts the date into a long format: hh:mm:ss
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
            //when form starts enable timer.
            timer1.Start();
            //Loads Method called populate.
            populate();
            //loads combo boxes with pre existing data from database
            fillBoatcombo();
            fillClientcombo();
        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
            res = DateTime.Compare(Datein.Value, today);
            if(res < 0)
            {
                MessageBox.Show("Please, pick a future date.");
            }
        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
            res = DateTime.Compare(Dateout.Value, today);
            if (res < 0)
            {
                MessageBox.Show("Please, pick a future date.");
            }
        }

        private void Reservation_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbxReservationID.Text = Reservation_GridView.SelectedRows[0].Cells[0].Value.ToString();
            ComboClient.Text = Reservation_GridView.SelectedRows[0].Cells[1].Value.ToString();
            ComboBoat.Text = Reservation_GridView.SelectedRows[0].Cells[2].Value.ToString();
            Datein.Text = Reservation_GridView.SelectedRows[0].Cells[3].Value.ToString();
            Dateout.Text = Reservation_GridView.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //image taken from: https://www.flaticon.com/free-icons/refresh Refresh icons created by Vectors Market - Flaticon
            populate();
            txbxReservationsearch.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string mysql = "Select * from Reservation_tbl where ReservationID = '" + txbxReservationsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Reservation_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void lbl_Date_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainBooking mainBooking = new MainBooking();
            mainBooking.Show();
            this.Hide();
        }
    }
}
