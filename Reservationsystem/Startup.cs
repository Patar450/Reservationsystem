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
            startpoint += 1;
            Progbar.Value = startpoint;
            if (Progbar.Value == 100 )
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
            this.timer1.Start();
        }
    }
}
