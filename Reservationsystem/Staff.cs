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
    public partial class Staff : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\source\repos\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        //loads the Client data from the database into the grid view
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Staff_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        public Staff()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //image taken from: https://www.flaticon.com/free-icons/refresh Refresh icons created by Vectors Market - Flaticon
            populate();
            txtbx_StaffSearch.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values('" + txbxStaffID.Text + "','" + txbxStaffName.Text + "','" + txbxStaffPhone.Text + "','" + comboGender.SelectedItem.ToString() + "','" + txbxStaffUser.Text + "','" + txbxStaffPassword.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            Con.Close();
            populate();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            //Converts the date into a long format: hh:mm:ss
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
            //when form starts enable timer.
            timer1.Start();
            //uses method to populate the grid with values fromt he database
            populate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Edits text from the CliendId.
            Con.Open();
            string myquery = "UPDATE Staff_tbl set Staffname = '" + txbxStaffName.Text + "', Staffphone = '" + txbxStaffPhone.Text + "', Gender = '" + comboGender.Text + "', Staffpassword =' " + txbxStaffPassword.Text + "', Staffusername ='" + txbxStaffUser.Text + "' where Staff_Id = '" + txbxStaffID.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void Staff_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Selected row autofills textboxes.
            txbxStaffID.Text = Staff_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txbxStaffName.Text = Staff_GridView.SelectedRows[0].Cells[1].Value.ToString();
            txbxStaffPhone.Text = Staff_GridView.SelectedRows[0].Cells[2].Value.ToString();
            comboGender.Text = Staff_GridView.SelectedRows[0].Cells[3].Value.ToString();
            txbxStaffPassword.Text = Staff_GridView.SelectedRows[0].Cells[4].Value.ToString();
            txbxStaffUser.Text = Staff_GridView.SelectedRows[0].Cells[5].Value.ToString();
 
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Staff_tbl where Staff_Id = " + txbxStaffID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deleted");
            Con.Close();
            populate();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();
            string mysql = "Select * from Staff_tbl where Staffname = '" + txtbx_StaffSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Staff_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
