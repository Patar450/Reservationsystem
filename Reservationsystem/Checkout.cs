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
    public partial class Checkout : Form
    {
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\OneDrive\Documents\School\STC School - Diploma\DDOOCP - Designing and Developing Object-Oriented Computer Programs (21 22) - FT - General\Assigment\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");
        DateTime today;
        private int res;
        private int res1;
        private int totalpriceincludingdate;

        FishingSer fishing = new FishingSer();
        Boatdiving diving = new Boatdiving();
        Boatparty Boatparty = new Boatparty();
        Privatecharter Privatecharter = new Privatecharter();

        public static class Global
        {
            public static string counter;
            public static string servicez;

            //boat class store variables
            public static string boatid;
            public static string boatname;
            public static bool available;
            public static bool equipment;
            public static int price;
            public static int maxprice;
            public static string refreshments;
            public static bool openbar;
        }
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // grabs the date today and stor it in today.
            today = Datein.Value;
            //Date lock button is diabled.
            btn_lock.Enabled = false;
            //when form starts enable timer.
            timer1.Start();

            txbxname.Text = Form1.Global.name;
            txbxaddress.Text = Form1.Global.address;
            txbxphone.Text = Form1.Global.phone;
            txbxBoatname.Text = Global.boatname;

            //Checks what is the next Id number.
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select COUNT(*) from Reservation_tbl ", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string savedata = dt1.Rows[0][0].ToString();
            int counter = 1 + Int32.Parse(savedata);
            txbxReservationID.Text = counter.ToString();
            Con.Close();
            int price;
            

            if (Global.servicez == "Fishing")
            {
                if (Global.equipment == false)
                {
                    price = Global.price;
                    int Maxprice = fishing.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else
                {
                    fishing.Fishequipment = true;
                    price = Global.price;
                    int Maxprice = fishing.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
            }
            else if (Global.servicez == "Diving")
            {
                if (Global.equipment == false && Global.refreshments == "None")
                {
                    price = Global.price;
                    int Maxprice = diving.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else if (Global.equipment == true && Global.refreshments == "None")
                {
                    diving.Divingequipment = true;
                    price = Global.price;
                    int Maxprice = diving.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else if (Global.equipment == false && Global.refreshments != "None")
                {
                    diving.Refreshment = Global.refreshments;
                    price = Global.price;
                    int Maxprice = diving.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else if (Global.equipment == true && Global.refreshments != "None")
                {
                    diving.Refreshment = Global.refreshments;
                    diving.Divingequipment = true;
                    price = Global.price;
                    int Maxprice = diving.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
            }
            else if (Global.servicez =="Party")
            {
                if (Global.openbar == false && Global.refreshments == "None")
                {
                    price = Global.price;
                    int Maxprice = Boatparty.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else if (Global.openbar == true && Global.refreshments == "None")
                {
                    Boatparty.Openbar = Global.openbar;
                    price = Global.price;
                    int Maxprice = Boatparty.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else if (Global.openbar == false && Global.refreshments != "None")
                {
                    Boatparty.Refreshment = Global.refreshments;
                    price = Global.price;
                    int Maxprice = Boatparty.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
                else if (Global.openbar == true && Global.refreshments != "None")
                {
                    Boatparty.Refreshment = Global.refreshments;
                    Boatparty.Openbar = Global.openbar;
                    price = Global.price;
                    int Maxprice = Boatparty.Discountcal(price);
                    txbxpricetotal.Text = Maxprice.ToString();
                }
            }
            else if (Global.servicez == "Charter")
            {
                Privatecharter.Refreshments = Global.refreshments;
                price = Global.price;
                int Maxprice = Privatecharter.Discountcal(price);
                txbxpricetotal.Text = Maxprice.ToString();
            }

        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
            res = DateTime.Compare(Datein.Value, today);
            if (res > 0)
            {
            }
            else
            {
                MessageBox.Show("Please, pick a future date.");
                btn_lock.Enabled = false; 
            }

        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            //res is used to check if the date enterred is before today
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientScreen clientScreen = new ClientScreen();
            clientScreen.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Updates timer every tick: making look like time is sychnonized with the clock.
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values('" + txbxReservationID.Text + "','" + txbxname.Text + "','" + txbxBoatname.Text + "','" + Datein.Text + "','" + Dateout.Text + "','"+txbxaddress.Text+"','"+txbxphone.Text+"','"+txbxpricetotal.Text+"','"+Global.price+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();

            string boatid1 = Global.counter;
            //Edits text from the CliendId.
            Con.Open();
            string myquery = "UPDATE Boat_tbl set Availability = 'No' where Boat_Id = '" + boatid1 + "';";
            SqlCommand cmd1 = new SqlCommand(myquery, Con);
            cmd1.ExecuteNonQuery();
            Con.Close();
            
            ClientScreen client = new ClientScreen();
            client.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Datein.Enabled = false;
            Dateout.Enabled = false;

            totalpriceincludingdate = Convert.ToInt32(txbxpricetotal.Text);
            var numberofdays = (Dateout.Value - Datein.Value).Days;
            int num = Convert.ToInt32(numberofdays);
            int totalpricez;
            totalpricez = num * Global.price;
            txbxpricetotal.Text = Convert.ToString(totalpricez);
            btn_confirm.Enabled = true;
            MessageBox.Show("Total price is now: "+ totalpricez);
        }
    }
}
