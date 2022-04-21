using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservationsystem
{
    internal class Boatdiving:Boat
    {
        //child class of boat
        private bool divingequipment;
        private string cancellationpolicy;
        private string refreshment;
        public bool Divingequipment
        {
            get { return divingequipment; }
            set { divingequipment = value; }
        }

        public string Refreshment
        {
            get { return refreshment; }
            set { refreshment = value; }
        }
        public string Cancellationpolicy
        {
            get { return cancellationpolicy; }
            set { cancellationpolicy = value; }
        }
        public Boatdiving(bool div, string can, string refr)
        {
            divingequipment = div;
            cancellationpolicy = can;
            refreshment = refr;
        }

        public Boatdiving()
        {
            divingequipment = false;
            cancellationpolicy = "1 day";
            refreshment = "none";
        }

        public override int Discountcal(int price)
        {
            int discount = 20;
            if (Divingequipment == false && Refreshment == "None")
            {
                Maxprice = price - discount;
                MessageBox.Show("We've applied a 20Eu discount.");
            }
            else if (Divingequipment == true && Refreshment == "None")
            {
      
                Maxprice = price + 100 - discount;
                MessageBox.Show("We've applied a 20Eu discount and added 100Eu for the diving equipment.");
            }
            else if (Divingequipment == false && Refreshment == "Food")
            {
                Maxprice = price + 50 - discount;
                MessageBox.Show("We've applied a 20Eu discount and added 50Eu for the Food Refreshment.");
            }
            else if (Divingequipment == true && Refreshment == "Food")
            {
                Maxprice = price + 150 - discount;
                MessageBox.Show("We've applied a 20Eu discount and added 150Eu for the Food Refreshment & diving equipment.");
            }
            else if (Divingequipment == false && Refreshment == "Drink")
            {
                Maxprice = price + 20 - discount;
                MessageBox.Show("We've applied a 20Eu discount and added 20Eu for the Drink Refreshment.");
            }
            else if (Divingequipment == true && Refreshment == "Drink")
            {
                Maxprice = price + 120 - discount;
                MessageBox.Show("We've applied a 20Eu discount and added 120Eu for the Drink Refreshment & diving equipment.");
            }

            return base.Discountcal(Maxprice);
        }
    }
}
