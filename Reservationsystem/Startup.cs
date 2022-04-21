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
    public partial class Startup : Form
    {
        private int startpoint = 0; 
        public Startup()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Generates random number between 1 - 5 inorder to mimic an actual loading screen
            Random rnd = new Random();
            startpoint += rnd.Next(1,5);

            //Problems occur when the total number added was more than 100 which goes above what the Progbar.Value can handle.
            //Added an if statement to ensure than if the Value goes above 100% will still act as thought the form loaded to 100%
            if (startpoint < 100)
            {
                Progbar.Value = startpoint;
                if (Progbar.Value >= 100)
                {
                    Progbar.Value = 0;
                    timer1.Stop();
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                Progbar.Value = 0;
                timer1.Stop();
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            
        }

        private void Progbar_Click(object sender, EventArgs e)
        {

        }

        private void Startup_Load(object sender, EventArgs e)
        {
            //Starts tick counter.
            this.timer1.Start();
        }
    }
}
