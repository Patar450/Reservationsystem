﻿using System;
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
        
        public ClientScreen()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
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
            timer1.Start();
            lblClientInformation.Text = "Welcome " + Form1.Global.name;
         
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Clientdetail clientdetail = new Clientdetail();
            clientdetail.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Image Obtained from: "https://www.flaticon.com/free-icons/document" Document icons created by Freepik - Flaticon
        }
    }
}