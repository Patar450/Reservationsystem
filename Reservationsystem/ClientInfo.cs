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
    public partial class ClientInfo : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True"); 
        
        //loads the Client data from the database into the grid view
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Client_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            //Converts the date into a long format: hh:mm:ss
            lbl_Date.Text=DateTime.Now.ToLongTimeString();
            //when form starts enable timer.
            timer1.Start();
            //Loads Method called populate.
            populate();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values('"+ txtbxClientID.Text + "','"+txbxClientName.Text+ "','"+txbxClientSurname.Text+"','"+txbxClientPhone.Text+"','"+ comboCountry.SelectedItem.ToString()+"','"+ txbxClientUser.Text + "','" + txbxClientPassword.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();

            populate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Edits text from the CliendId.
            Con.Open();
            string myquery = "UPDATE Client_tbl set ClientName = '" + txbxClientName.Text + "', ClientSurname = '" + txbxClientSurname.Text + "', ClientPhone = '" + txbxClientPhone.Text + "', ClientCountry =' " + comboCountry.Text + "', ClientUsername ='" + txbxClientUser.Text + "', ClientPassword =' " + txbxClientPassword.Text + "' where ClientId = '"+ txtbxClientID.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Client_tbl where ClientId = " + txtbxClientID.Text + ""; 
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();
            populate();
        }

        private void Client_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Selected row autofills textboxes.
            txtbxClientID.Text = Client_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txbxClientName.Text = Client_GridView.SelectedRows[0].Cells[1].Value.ToString();
            txbxClientSurname.Text = Client_GridView.SelectedRows[0].Cells[2].Value.ToString();
            txbxClientPhone.Text = Client_GridView.SelectedRows[0].Cells[3].Value.ToString();
            comboCountry.Text = Client_GridView.SelectedRows[0].Cells[4].Value.ToString();
            txbxClientUser.Text = Client_GridView.SelectedRows[0].Cells[5].Value.ToString();
            txbxClientPassword.Text = Client_GridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();
            string mysql = "Select * from Client_tbl where ClientName = '"+ txtbx_ClientSearch.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Client_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //image taken from: https://www.flaticon.com/free-icons/refresh Refresh icons created by Vectors Market - Flaticon
            populate();
            txtbx_ClientSearch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainBooking frm = new MainBooking();
            frm.Show();
            this.Hide();
        }
    }
}
