using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservationsystem
{
    internal class Privatecharter:Boat
    {
        //child class of boat
        private string cancellationpolicy;
        private string refreshments;

        public string CancellationPolicy
        {
            get { return cancellationpolicy; }
            set { cancellationpolicy = value; }
        }

        public string Refreshments
        {
            get { return refreshments; }
            set { refreshments = value; }
        }
        public Privatecharter(string can, string refr)
        {
            cancellationpolicy = can;
            refreshments = refr;
        }

        public Privatecharter()
        {
            cancellationpolicy = "5 days";
            refreshments = "None";
        }

        public override int Discountcal(int price)
        {
            int discount = 100;
            if (Refreshments == "None")
            {
               
                Maxprice = price - discount;
                MessageBox.Show("We've applied a 100Eu discount.");
            }
            else if (Refreshments == "Food")
            {
                
                Maxprice = price + 200 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 200Eu for the Food Refreshments.");
            }
            else if (Refreshments == "Drink")
            {
                Maxprice = price + 100 - discount;
                MessageBox.Show("We've applied a 100Eu discount and added 100Eu for the Drinks Refreshments.");
            }
            return base.Discountcal(Maxprice);

        }
    }
}
