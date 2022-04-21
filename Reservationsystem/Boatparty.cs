using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservationsystem
{
    internal class Boatparty:Boat
    {
        //child class of boat
        private string refreshment;
        private bool openbar;
        private string cancellationpolicy;

        public string Refreshment
        {
            get { return refreshment; }
            set { refreshment = value; }
        }

        public bool Openbar
        {
            get { return openbar; }
            set { openbar = value; }
        }

        public string CancellationPolicy
        {
            get { return cancellationpolicy; }
            set { cancellationpolicy = value; }
        }
        public Boatparty(string refr, bool op, string can )
        {
            refreshment = refr;
            openbar = op;
            cancellationpolicy = can;
        }

        public Boatparty()
        {
            refreshment = "None";
            cancellationpolicy = "None";
            openbar=false;
        }

        public override int Discountcal(int price)
        {
            int discount = 100;
           
            if (openbar == false && Refreshment == "None")
            {
                Maxprice = price - discount;
                MessageBox.Show("We've applied a 100Eu discount.");
            }
            else if (openbar == true && Refreshment == "None")
            {
                Maxprice = price + 500 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 500Eu for the OpenBar.");
            }
            else if (openbar == false && Refreshment == "Food")
            {
                Maxprice = price + 150 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 150Eu for the Food Refreshment.");
            }
            else if (openbar == true && Refreshment == "Food")
            {
                Maxprice = price + 650 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 650Eu for the Food Refreshment & Open bar.");
            }
            else if (openbar == false && Refreshment == "Drink")
            {
                Maxprice = price + 80 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 80Eu for the Drink Refreshment.");
            }
            else if (openbar == true && Refreshment == "Drink")
            {
                Maxprice = price + 120 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 580Eu for the Drink Refreshment & Open bar.");
            }

            return base.Discountcal(Maxprice);

            
        }
    }
}
