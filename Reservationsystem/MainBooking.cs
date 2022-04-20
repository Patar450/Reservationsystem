using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservationsystem
{
    public partial class MainBooking : Form
    {
        public MainBooking()
        {
            InitializeComponent();
        }

        private void Staffpic_Click(object sender, EventArgs e)
        {
            //Icon obtained from image: https://www.flaticon.com/free-icons/man Man icons created by Freepik - Flaticon
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Icon Obtained from: https://www.flaticon.com/free-icons/staff Staff icons created by alkhalifi design - Flaticon
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Icon obtained from: https://www.flaticon.com/free-icons/client Client icons created by DinosoftLabs - Flaticon
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Icon Obtained from: https://www.flaticon.com/free-icons/speed-boat Speed boat icons created by tulpahn - Flaticon
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Icon Obtained from: https://www.flaticon.com/free-icons/log-out Log out icons created by inkubators - Flaticon
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Icon Obtained from: https://www.flaticon.com/free-icons/calendar Calendar icons created by Becris - Flaticon
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btn_Boat_Details_Click(object sender, EventArgs e)
        {
            BoatInfo boatinfo = new BoatInfo();
            boatinfo.Show();
            this.Hide();
        }

        private void btn_Reservation_Details_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }
    }
}
