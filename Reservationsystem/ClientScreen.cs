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
    public partial class ClientScreen : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\OneDrive\Documents\School\STC School - Diploma\DDOOCP - Designing and Developing Object-Oriented Computer Programs (21 22) - FT - General\Assigment\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");   //Date variable stored and used in the respopulate() method.
        DateTime today;
        //res variable to determin if the dateIn is a few days after today and DateOut are is a few days before today.
        private int res;

        //Populates Gridview with all the reviews left by the users.
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Review_tbl;";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Boat_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        //Notification ping alert.
        private void showDialog(String message)
        {
            DialogForm dialog = new DialogForm(message);
            dialog.TopMost = true;
            dialog.Show();
        }
        //Mthod to check if a booking is due in a few days
        public void ToastMessage()
        {
            SqlDataAdapter sda9 = new SqlDataAdapter("select COUNT(DateIn) from Reservation_tbl where Client = '" + Form1.Global.name + "'; ", Con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            int countholder1 = Convert.ToInt32(dt9.Rows[0][0]);
            Con.Close();

            //For loop, to loop all the booking the user has and check if any of them is due in a few days.
            for (int i = 0; i < countholder1; i++)
            {
               
                DateTime dateTime = Convert.ToDateTime(ReservationsDateoutgrid.Rows[i].Cells[3].Value.ToString());
                DateTime today = DateTime.Now;
                res = DateTime.Compare(dateTime, today);

                //if a date is found which is less than 0 (0 being Today and less would be yesterday onwards)
                if (res > 0)
                {
                    string dateholder1 = dateTime.ToString();
                    //Remove(10) is to remove the time that is stored in the Database DateIn. 
                    //Example: 10/10/2010 00:00. With the remove the string becomes just 10/10/2010
                    showDialog(dateholder1.Remove(10));
                    //breaks out of the loop
                    break;
                }
            }
        }
        //populates a hidden gridview to load all the booking the user has and if there is a booking coming up in a few days a notification will apear as a reminder.
        //If the booking as been completed a review windows will appear and will delete the booking as well as putting the boat back to available
        public void populateres()
        {
            Con.Open();
            string mysql1 = "Select * from Reservation_tbl where Client='"+Form1.Global.name+"';";
            SqlDataAdapter da1 = new SqlDataAdapter(mysql1, Con);
            SqlCommandBuilder cbuilder1 = new SqlCommandBuilder(da1);
            var ds1 = new DataSet();
            da1.Fill(ds1);
            ReservationsDateoutgrid.DataSource = ds1.Tables[0];
            
            SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(DateOut) from Reservation_tbl where Client='" + Form1.Global.name + "';", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            int countholder = Convert.ToInt32(dt1.Rows[0][0]);
            Con.Close();

            for (int i = 0; i < countholder;  i++)
            {

                DateTime dateTime = Convert.ToDateTime(ReservationsDateoutgrid.Rows[i].Cells[4].Value.ToString());
                DateTime today = DateTime.Now;
                res = DateTime.Compare(dateTime, today);

                if (res < 0)
                {
                    //puts back the Boat to Available.
                    Con.Open();
                    string myquery = "UPDATE Boat_tbl set Availability = 'Yes' where BoatName = '" + ReservationsDateoutgrid.Rows[i].Cells[2].Value.ToString() + "';";
                    SqlCommand cmd1 = new SqlCommand(myquery, Con);
                    cmd1.ExecuteNonQuery();
                    Con.Close();
                    //Deletes the reservation
                    Con.Open();
                    string query = "delete from Reservation_tbl where BoatName = '" + ReservationsDateoutgrid.Rows[i].Cells[2].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    //Loads review message.
                    this.WindowState = FormWindowState.Minimized;
                    MessageBox.Show("I can see that you've used our service before. Please leave a review to help us improve our services :)");
                    LeaveaReview leaveaReview = new LeaveaReview();
                    leaveaReview.Show();
                    break;
                }
            }
        }

        public ClientScreen()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //exits appilication
            Application.Exit();
        }

        private void lblClientInformation_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            lbl_Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientScreen_Load(object sender, EventArgs e)
        {
            
            //The form will load in Fullscreen to ensure that people will sight issue will be able to see all the features the program provides.

            //Timer start ticking to sychronize a clock.
            timer1.Start();
            //A Welcome title will be visible at the top of the screen for the user.
            lblClientInformation.Text = "Welcome " + Form1.Global.name;
            //Populates the gridview will all the reviews left there from other users. (It's available Public.)
            populate();
            
            //Method to check if a booking has expired.
            //See line: 74
            populateres();

            //Checks to see if a reminder of a booking is needed.
            //See line: 44
            ToastMessage();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Image Obtined from: "https://www.flaticon.com/free-icons/account" Account icons created by SBTS2018 - Flaticon
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Image Obtined from: "https://www.flaticon.com/free-icons/fishing"Fishing icons created by wanicon - Flaticon
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //goes back to the loginscreen
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            //loads Client details form
            Clientdetail clientdetail = new Clientdetail();
            clientdetail.TopMost = true;
            clientdetail.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Image Obtained from: "https://www.flaticon.com/free-icons/document" Document icons created by Freepik - Flaticon
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Loads the clients orders
            MyOrders myOrders = new MyOrders();
            myOrders.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Loads the boat booking screen
            this.Hide();
            BoatInfo fish = new BoatInfo();
            fish.Show();
        }

        private void Boat_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void ReservationsDateoutgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
