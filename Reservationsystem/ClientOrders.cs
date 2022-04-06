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
    public partial class ClientOrders : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        DateTime today;
        private int res;
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Reservation_tbl where Client = '"+Form1.Global.name+"';";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Reservation_GridView.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void fillBoatcombo()
        {
            Con.Open();
            string boatstate = "Free";
            SqlCommand cmd = new SqlCommand("Select BoatName from Boat_tbl where BoatFree = '" + boatstate + "'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BoatName", typeof(string));
            dt.Load(rdr);
            ComboBoat.ValueMember = "BoatName";
            ComboBoat.DataSource = dt;
            Con.Close();
        }
        //updates the boat that is added to the busy list.
        public void updatereservations()
        {
            Con.Open();
            string remove = "Busy";
            string myquery = "UPDATE Boat_tbl set BoatFree = '" + remove + "' where BoatName = '" + ComboBoat.SelectedValue.ToString() + "';";
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
        public ClientOrders()
        {
            InitializeComponent();
        }

        private void lblClientInformation_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void Reservation_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbxReservationID.Text = Reservation_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txbxClientName.Text = Reservation_GridView.SelectedRows[0].Cells[1].Value.ToString();
            ComboBoat.Text = Reservation_GridView.SelectedRows[0].Cells[2].Value.ToString();
            Datein.Text = Reservation_GridView.SelectedRows[0].Cells[3].Value.ToString();
            Dateout.Text = Reservation_GridView.SelectedRows[0].Cells[4].Value.ToString();
            richreview.Text = Reservation_GridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con.Open();
            //Checks what is the next Id number.
            SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Reservation_tbl ", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string savedata = dt1.Rows[0][0].ToString();
            int counter = 1 + Int32.Parse(savedata);
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values('" + counter + "','" + txbxClientName.Text + "','" + ComboBoat.SelectedValue.ToString() + "','" + Datein.Text + "','" + Dateout.Text+ "','" + richreview.Text +"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            updatereservations();
            populate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (ComboBoat.Text == null)
            {
                MessageBox.Show("Fill in all the details to be edited.");
            }
            else
            {
                //Edits text from the Reservation_tbl.
                Con.Open();
                string myquery = "UPDATE Reservation_tbl set Client = '" + txbxClientName.Text + "', Boat = '" + ComboBoat.SelectedValue.ToString() + "', DateIn = '" + Datein.Value + "', DateOut =' "+ Dateout.Value +"', Reviewfrmpreviusowner"+richreview.Text+"' where ReservationId = '" + txbxReservationID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation changed Successfully ");
                Con.Close();
                populate();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txbxReservationID.Text == "")
            {
                MessageBox.Show("Select the Reservation to be deleted.");
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

        private void ClientOrders_Load(object sender, EventArgs e)
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
            
        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
            res = DateTime.Compare(Datein.Value, today);
            if (res < 0)
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
    }
}
