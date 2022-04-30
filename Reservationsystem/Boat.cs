using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservationsystem
{
    //Creates a base class for Boats. For this version of the program, not all attributes will be used in the main program.
    //However they are created in case a new feature will be needed to be able to create a new Boat within the program itself. 
    //In this version only the id,name,service,price,available and maxprice will be used. The rest are all using the default values.
    internal class Boat
    {
        private int id;
        private string name;
        private string service;
        private bool available;
        private string minmumlenghtofcharter;
        private int price;
        private string port;
        private string typeofboat;
        private string model;
        private string manufacturer;
        private int boatlenght;
        private int beam;
        private int draft;
        private int yearofconstruction;
        private int speed;
        private int crew;
        private string enginetype;
        private string engine;
        private int pax;
        private int cabin;
        private int bed;
        private int shower;
        private int watercapacity;
        private int fuelTankCapacity;
        private int fuelconsumption;
        private int maxprice;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Service
        {
            get { return service; }
            set { service = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public string Minmumlenghtofcharter
        {
            get { return minmumlenghtofcharter;}
            set { minmumlenghtofcharter = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Maxprice
        {
            get { return maxprice; }
            set { maxprice = value; }
        }
        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        public string Typeofboat
        { 
            get { return typeofboat; }
            set { typeofboat = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public int Boatlenght
        {
            get { return boatlenght; }
            set { boatlenght = value; }
        }
        public int Beam
        {
            get { return beam; }
            set { beam = value; }
        }
        public int Draft
        {
            get { return draft; }
            set { draft = value; }
        }
        public int Yearofconstruction
        {
            get { return yearofconstruction; }
            set { yearofconstruction = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Crew
        {
            get { return crew; }
            set { crew = value; }
        }
        public string Enginetype
        {
            get { return enginetype; }
            set { enginetype = value; }
        }
        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Pax
        {
            get { return pax; }
            set { pax = value; }
        }
        public int Cabin
        {
            get { return cabin; }
            set { cabin = value; }
        }
        public int Bed
        {
            get { return bed; }
            set { bed = value; }
        }
        public int Shower
        {
            get { return shower; }
            set { shower = value; }
        }
        public int Watercapacity
        {
            get { return watercapacity; }
            set { watercapacity = value; }
        }
        public int Feultankcapacity
        {
            get { return fuelTankCapacity; }
            set { fuelTankCapacity = value;}
        }
        public int Fuelconsumption
        {
            get { return fuelconsumption; }
            set { fuelconsumption = value; }
        }

        public Boat(int idnum,string nam, string ser, bool av, string mini, int pri, int mpri, string pt, string type, string mod, string manu, int len, int be, int dra, int yearo, int sp, int ct, string engt, string eng, int pass, int cb,int bd, int wat,int fetaca, int fc )
        {
            id = idnum;
            name = nam;
            service = ser;
            available = av;
            minmumlenghtofcharter = mini;
            price = pri;
            port = pt;
            typeofboat = type;
            model = mod;
            manufacturer = manu;
            boatlenght = len;
            beam = be;
            draft = dra;
            yearofconstruction = yearo;
            speed = sp;
            crew = ct;
            enginetype = engt;
            engine = eng;
            pax = pass;
            cabin = cb;
            bed = bd;
            watercapacity = wat;
            fuelTankCapacity = fetaca;
            fuelconsumption = fc;
        }

        public Boat()
        {
            id = 0;
            name = "blank";
            service = "blank";
            available = false;
            minmumlenghtofcharter = "blank";
            price = 0;
            maxprice = 0;
            port = "blank";
            typeofboat = "blank";
            model = "blank";
            manufacturer = "blank";
            boatlenght = 0;
            beam = 0;
            draft = 0;
            yearofconstruction = 0;
            speed = 0;
            crew = 0;
            enginetype = "blank";
            engine = "blank";
            pax = 0;
            cabin = 0;
            bed = 0;
            watercapacity = 0;
            fuelTankCapacity = 0;
            fuelconsumption = 0;
        }
        //Method than implemts discounts.
        public virtual int Discountcal(int price)
        {
            int discount = 0;
            maxprice = price - discount;
            return maxprice;
        }
    }
}
