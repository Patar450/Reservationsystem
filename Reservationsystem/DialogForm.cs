using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Reservationsystem
{
    public partial class DialogForm : Form
    {
        SoundPlayer player = new SoundPlayer(soundLocation: @"C:\Users\Patar\OneDrive\Documents\School\STC School - Diploma\DDOOCP - Designing and Developing Object-Oriented Computer Programs (21 22) - FT - General\Assigment\Reservationsystem\Reservationsystem\bin\Debug\Alert.wav");
        public DialogForm(String Message)
        {
            InitializeComponent();
            
            lblmessage.Text = "Reminder! Booked a boat on:\n" + Message;
            try
            {
                player.Play();
            }
            catch
            {
                MessageBox.Show("Audio File didn't load. Please change the file location in DialogFrom");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height - 50;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 10;
            timerClose.Start();
        }
    }
}
