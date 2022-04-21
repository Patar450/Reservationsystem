using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservationsystem
{
    internal class FishingSer:Boat
    {
        //child class of boat
        private bool fishequipment;
        private string cancellationpolicy;

        public bool Fishequipment
        {
            get { return fishequipment; }
            set { fishequipment = value; }
        }

        public string Cancellationpolicy
        {
            get { return cancellationpolicy; }
            set { cancellationpolicy = value; }
        }

        public FishingSer(bool fishe,string can)
        {
            fishequipment = fishe;
            cancellationpolicy = can;
        }

        public FishingSer()
        {
            fishequipment=false;
            cancellationpolicy = "1 week";
        }

        public override int Discountcal(int price)
        {
            if (Fishequipment == false)
            {
                int discount = 200;
                Maxprice = price - discount;
                MessageBox.Show("We've applied a 200Eu discount.");
            }
            else if (Fishequipment == true)
            {
                int discount = 200;
                Maxprice = price + 50 - discount;
                MessageBox.Show("We've applied a 200Eu discount and added 50Eu for the fishing equipment.");
            }
            return base.Discountcal(Maxprice);
        }
    }
}
