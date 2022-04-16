using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Reservationsystem
{
    public partial class Testing : Form
    {

        public int counter;
        public int counter2;
     OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Patar\OneDrive\Documents\Reservationsystem\Reservationsystem\bin\Debug\ReservationSystem1.accdb");
        public Testing()
        {
            InitializeComponent();
        }
        List<Boat> boats = new List<Boat>();
        Boat boat1;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            counter2 = boats.Count() - 1;
            counter = boats.Count() + 1;
            int boatid = counter;
            string typeofboat = txbxtype.Text;
            string model = txbxmodel.Text;
            string manu = txbxmanu.Text;
            int lenght = Convert.ToInt32(txbxlenght.Text);
            int beam = Convert.ToInt32(txbxbeam.Text);
            int draft = Convert.ToInt32(txbxdraft.Text);
            string year = txbxyears.Text;
            int speed = Convert.ToInt32(txbxspeed.Text);   
            string crew = txbxcrewtype.Text;
            string enginetype = txbxenginetype.Text;
            int engine = Convert.ToInt32(txbxengine.Text);
            int water = Convert.ToInt32(txbxwater.Text);
            int feultankcap = Convert.ToInt32(txbxcapac.Text);

            //boats.Add(boat1 = new Boat(boatid, typeofboat, model, manu, lenght, beam, draft, year, speed, crew, enginetype, engine, water, feultankcap));

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Boat values('"+ boats.ElementAt(0).Id +"','"+ boats.ElementAt(0).Typeofboat+"','"+boats.ElementAt(0).Model+"','"+boats.ElementAt(0).Manufacturer+"','"+boats.ElementAt(0).Lenght+"','"+boats.ElementAt(0).Beam+"','"+boats.ElementAt(0).Draft+"','"+boats.ElementAt(0).Yearofconstruction+"','"+boats.ElementAt(0).Speed+"','"+boats.ElementAt(0).Crewtype+"','"+boats.ElementAt(0).Enginetype+"','"+boats.ElementAt(0).Engine+"','"+boats.ElementAt(0).Water+"','"+boats.ElementAt(0).Feultankcapacity+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("completed");
            */
        }

        private void Testing_Load(object sender, EventArgs e)
        {

        }
    }
}
