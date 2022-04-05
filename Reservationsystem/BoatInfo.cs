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
    

    public partial class BoatInfo : Form
    {
        private string isfree = null;

        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        //loads the Client data from the database into the grid view
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Boat_tbl";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Boat_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public BoatInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void BoatInfo_Load(object sender, EventArgs e)
        {
            //Converts the date into a long format: hh:mm:ss
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
            //when form starts enable timer.
            timer1.Start();
            //Loads Method called populate.
            populate();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (RadioYes.Checked == true)
            {
                isfree = "Free";
            }
            else if (RadioNo.Checked == true)
            {
                isfree = "Busy";
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Boat_tbl values('" + txbxBoatID.Text + "','" + txbxBoatModel.Text + "','" + txbxBoatName.Text + "','" + comboYear.SelectedItem.ToString() + "','" + combobtft.SelectedItem.ToString() + "','" + combocabin.SelectedItem.ToString() + "','" + combowc.SelectedItem.ToString() + "','" +combopax.SelectedItem.ToString() + "','" +txbxboatrent.Text + "','" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Boat Successfully Added");
            Con.Close();

            populate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Edits text from the BoatId.
            Con.Open();
            string myquery = "UPDATE Boat_tbl set BoatModel = '" + txbxBoatModel.Text + "', BoatName = '" + txbxBoatName.Text + "', BoatYear = '" + comboYear.Text + "', BoatFT =' " + combobtft.Text + "', BoatCabin ='" + combocabin.Text + "', BoatWC =' " + combowc.Text + "', BoatPAX =' " +combopax.Text + "', BoatRent =' " +txbxboatrent.Text + "', BoatFree =' " + isfree + "' where Boat_Id = '" + txbxBoatID.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Boat Successfully Edited");
            Con.Close();
            populate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Boat_tbl where Boat_Id = " + txbxBoatID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Boat Successfully Deleted");
            Con.Close();
            populate();
        }

        private void Boat_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Selected row autofills textboxes.
            txbxBoatID.Text = Boat_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txbxBoatModel.Text = Boat_GridView.SelectedRows[0].Cells[1].Value.ToString();
            txbxBoatName.Text = Boat_GridView.SelectedRows[0].Cells[2].Value.ToString();
            comboYear.Text = Boat_GridView.SelectedRows[0].Cells[3].Value.ToString();
            combobtft.Text = Boat_GridView.SelectedRows[0].Cells[4].Value.ToString();
            combocabin.Text = Boat_GridView.SelectedRows[0].Cells[5].Value.ToString();
            combowc.Text = Boat_GridView.SelectedRows[0].Cells[6].Value.ToString();
            combopax.Text = Boat_GridView.SelectedRows[0].Cells[7].Value.ToString();
            txbxboatrent.Text = Boat_GridView.SelectedRows[0].Cells[8].Value.ToString();

            if (Boat_GridView.SelectedRows[0].Cells[9].Value.ToString() == "Free")
            {
                RadioNo.Checked = false;
                RadioYes.Checked = true;
               
            }
            else if (Boat_GridView.SelectedRows[0].Cells[9].Value.ToString() == "Busy")
            {
                RadioNo.Checked = true;
                RadioYes.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //image taken from: https://www.flaticon.com/free-icons/refresh Refresh icons created by Vectors Market - Flaticon
            populate();
            txtbx_BoatSearch.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();
            string mysql = "Select * from Boat_tbl where BoatName = '" + txtbx_BoatSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Boat_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainBooking mainBooking = new MainBooking();
            mainBooking.Show();
            this.Hide();
        }
    }
}
