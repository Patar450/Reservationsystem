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

        private string serviceplaceholder;
        //Establishes a connection to the SQL Database.
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patar\OneDrive\Documents\School\STC School - Diploma\DDOOCP - Designing and Developing Object-Oriented Computer Programs (21 22) - FT - General\Assigment\Reservationsystem\Reservationsystem\Boat.mdf;Integrated Security=True");

        //loads the Client data from the database into the grid view
        public void populate()
        {
            Con.Open();
            string mysql = "Select * from Boat_tbl where Availability ='Yes'";
            SqlDataAdapter da = new SqlDataAdapter(mysql, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Boat_GridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void populatewithservice(string serviceplaceholder)
        {
            Con.Open();
            string mysql = "Select * from Boat_tbl where Availability ='Yes' AND Service = '"+ serviceplaceholder + "'";
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
            MessageBox.Show("Choose from the service combobox to get started :)");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(serviceplaceholder == "Fishing")
            {
                if (RadioYes.Checked == false && RadioNo.Checked == false || txbxBoatID.Text == "")
                {
                    MessageBox.Show("Please,ensure you choose whether you want us to provide fishing equipment or not.");
                }
                else
                {
                    Checkout.Global.counter = txbxBoatID.Text;
                    Checkout.Global.servicez = "Fishing";
                    Checkout.Global.boatname = txbxname.Text;
                    Checkout.Global.price = Convert.ToInt32(txbxprice.Text);
                    if (RadioYes.Checked == true && RadioNo.Checked == false)
                    {
                        Checkout.Global.equipment = true;
                    }
                    else if (RadioNo.Checked == true && RadioYes.Checked == false)
                    {
                        Checkout.Global.equipment = false;
                    }    

                    this.Hide();
                    Checkout checkout = new Checkout();
                    checkout.Show();
                }
            }
            else if (serviceplaceholder == "Diving")
            {
                if(radiodiveqYes.Checked == false && radioDiveqNo.Checked == false || radioDivingFood.Checked == false && radioDivingdrinks.Checked == false && radioDivingNone.Checked == false)
                {
                    MessageBox.Show("Please,ensure you choose all the neccassary options");
                }
                else
                {
                    Checkout.Global.counter = txbxBoatID.Text;
                    Checkout.Global.servicez = "Diving";
                    Checkout.Global.boatname = txbxname.Text;
                    Checkout.Global.price = Convert.ToInt32(txbxprice.Text);
                    if (radiodiveqYes.Checked == true && radioDiveqNo.Checked == false)
                    {
                        Checkout.Global.equipment = true;
                    }
                    else if(radioDiveqNo.Checked == true && radiodiveqYes.Checked == false)
                    {
                        Checkout.Global.equipment = false;
                    }
                    if (radioDivingFood.Checked == true && radioDivingdrinks.Checked == false && radioDivingNone.Checked == false)
                    {
                        Checkout.Global.refreshments = "Food";
                    }
                    else if (radioDivingFood.Checked == false && radioDivingdrinks.Checked == true && radioDivingNone.Checked == false)
                    {
                        Checkout.Global.refreshments = "Drink";
                    }
                    else if(radioDivingFood.Checked == false && radioDivingdrinks.Checked == false && radioDivingNone.Checked == true)
                    {
                        Checkout.Global.refreshments = "None";
                    }
                    this.Hide();
                    Checkout checkout = new Checkout();
                    checkout.Show();
                }
            }
            else if (serviceplaceholder == "Charter")
            {
                

                if (radiocharterfood.Checked == false && radiocharterdrinks.Checked == false && radiocharternone.Checked == false)
                {
                    MessageBox.Show("Please,ensure you choose all the neccassary options");
                }
                else
                {
                    Checkout.Global.counter = txbxBoatID.Text;
                    Checkout.Global.servicez = "Charter";
                    Checkout.Global.boatname = txbxname.Text;
                    Checkout.Global.price = Convert.ToInt32(txbxprice.Text);
                    if (radiocharterfood.Checked == true && radiocharterdrinks.Checked == false && radiocharternone.Checked == false)
                    {
                        Checkout.Global.refreshments = "Food";
                    }
                    else if (radiocharterfood.Checked == false && radiocharterdrinks.Checked == true && radiocharternone.Checked == false)
                    {
                        Checkout.Global.refreshments = "Drink";
                    }
                    else if (radiocharterfood.Checked == false && radiocharterdrinks.Checked == false && radiocharternone.Checked == true)
                    {
                        Checkout.Global.refreshments = "None";
                    }
                    this.Hide();
                    Checkout checkout = new Checkout();
                    checkout.Show();
                }
                
            }
            else if (serviceplaceholder == "Party")
            {
                

                if (radioFood.Checked == false && radioDrinks.Checked == false && radioNone.Checked == false|| radioopenyes.Checked == false && radioopenyes.Checked ==false)
                {
                    MessageBox.Show("Please,ensure you choose all the neccassary options");
                }
                else
                {
                    Checkout.Global.counter = txbxBoatID.Text;
                    Checkout.Global.servicez = "Party";
                    Checkout.Global.boatname = txbxname.Text;
                    Checkout.Global.price = Convert.ToInt32(txbxprice.Text);

                    if (radioFood.Checked == true && radioDrinks.Checked == false && radioNone.Checked == false)
                    {
                        Checkout.Global.refreshments = "Food";
                    }
                    else if (radioFood.Checked == false && radioDrinks.Checked == true && radioNone.Checked == false)
                    {
                        Checkout.Global.refreshments = "Drink";
                    }
                    else if (radioFood.Checked == false && radioDrinks.Checked == false && radioNone.Checked == true)
                    {
                        Checkout.Global.refreshments = "None";
                    }

                    if (radioopenyes.Checked == true && radioOpenNo.Checked == false)
                    {
                        Checkout.Global.openbar = true;
                    }
                    else if (radioopenyes.Checked == false && radioOpenNo.Checked == true)
                    {
                        Checkout.Global.openbar = false;
                    }
                    this.Hide();
                    Checkout checkout = new Checkout();
                    checkout.Show();
                }
            }
            
        }

        private void Boat_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Selected row autofills textboxes.
            txbxBoatID.Text = Boat_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txbxname.Text = Boat_GridView.SelectedRows[0].Cells[1].Value.ToString();
            txbxcharter.Text = Boat_GridView.SelectedRows[0].Cells[4].Value.ToString();
            txbxprice.Text = Boat_GridView.SelectedRows[0].Cells[5].Value.ToString();
            txbxport.Text = Boat_GridView.SelectedRows[0].Cells[6].Value.ToString();
            txbxtype.Text = Boat_GridView.SelectedRows[0].Cells[7].Value.ToString();
            txbxmodel.Text = Boat_GridView.SelectedRows[0].Cells[8].Value.ToString();
            txbxmanu.Text = Boat_GridView.SelectedRows[0].Cells[9].Value.ToString();
            txbxlenght.Text = Boat_GridView.SelectedRows[0].Cells[10].Value.ToString();
            txbxbeam.Text = Boat_GridView.SelectedRows[0].Cells[11].Value.ToString();
            txbxdraft.Text = Boat_GridView.SelectedRows[0].Cells[12].Value.ToString();
            txbxyear.Text = Boat_GridView.SelectedRows[0].Cells[13].Value.ToString();
            txbxspeed.Text = Boat_GridView.SelectedRows[0].Cells[14].Value.ToString();
            txbxcrew.Text = Boat_GridView.SelectedRows[0].Cells[15].Value.ToString();
            txbxenginetype.Text = Boat_GridView.SelectedRows[0].Cells[16].Value.ToString();
            txbxengine.Text = Boat_GridView.SelectedRows[0].Cells[17].Value.ToString();
            txbxpax.Text = Boat_GridView.SelectedRows[0].Cells[18].Value.ToString();
            txbxcabin.Text = Boat_GridView.SelectedRows[0].Cells[19].Value.ToString();
            txbxbed.Text = Boat_GridView.SelectedRows[0].Cells[20].Value.ToString();
            txbxshower.Text = Boat_GridView.SelectedRows[0].Cells[21].Value.ToString();
            txbxwater.Text = Boat_GridView.SelectedRows[0].Cells[22].Value.ToString();
            txbxcap.Text = Boat_GridView.SelectedRows[0].Cells[23].Value.ToString();
            txbxfuelcons.Text = Boat_GridView.SelectedRows[0].Cells[24].Value.ToString();
            txbxcancel.Text = Boat_GridView.SelectedRows[0].Cells[27].Value.ToString();

            //turns off radio buttons
            RadioYes.Checked = false;
            RadioNo.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientScreen client = new ClientScreen();
            client.Show();
            this.Hide();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboservice.Text == "Fishing")
            {
                serviceplaceholder = "Fishing";
                populatewithservice(serviceplaceholder);
                Boat_GridView.Enabled = true;
                gpbxfishing.Enabled = true;
                gpbxdiving.Enabled = false;
                gpbxcharter.Enabled = false;
                gpbxparty.Enabled = false;
            }
            else if(comboservice.Text == "Charter")
            {
                serviceplaceholder = "Charter";
                populatewithservice(serviceplaceholder);
                Boat_GridView.Enabled = true;
                gpbxfishing.Enabled = false;
                gpbxdiving.Enabled = false;
                gpbxcharter.Enabled = true;
                gpbxparty.Enabled = false;
            }
            else if(comboservice.Text=="Diving")
            {
                serviceplaceholder = "Diving";
                populatewithservice(serviceplaceholder);
                Boat_GridView.Enabled = true;
                gpbxfishing.Enabled = false;
                gpbxdiving.Enabled = true;
                gpbxcharter.Enabled = false;
                gpbxparty.Enabled = false;
            }
            else if (comboservice.Text=="Party")
            {
                serviceplaceholder = "Party";
                populatewithservice(serviceplaceholder);
                Boat_GridView.Enabled = true;
                gpbxfishing.Enabled = false;
                gpbxdiving.Enabled = false;
                gpbxcharter.Enabled = false;
                gpbxparty.Enabled = true;
            }
            else
            {
                populate();
            }

        }

        private void radioNone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDrinks_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
