namespace Reservationsystem
{
    partial class MyOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lblClientInformation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reservation_GridView = new System.Windows.Forms.DataGridView();
            this.gpbxReservationDetails = new System.Windows.Forms.GroupBox();
            this.txbxBoatname = new System.Windows.Forms.TextBox();
            this.btn_lock = new System.Windows.Forms.Button();
            this.txbxpricetotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbxphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxname = new System.Windows.Forms.TextBox();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.txbxReservationID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbxprice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_GridView)).BeginInit();
            this.gpbxReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_Date);
            this.panel1.Controls.Add(this.lblClientInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1730, 192);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(1283, 67);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(251, 108);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lblClientInformation
            // 
            this.lblClientInformation.AutoSize = true;
            this.lblClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInformation.Location = new System.Drawing.Point(38, 67);
            this.lblClientInformation.Name = "lblClientInformation";
            this.lblClientInformation.Size = new System.Drawing.Size(501, 108);
            this.lblClientInformation.TabIndex = 0;
            this.lblClientInformation.Text = "My Orders";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reservation_GridView
            // 
            this.Reservation_GridView.AllowUserToAddRows = false;
            this.Reservation_GridView.AllowUserToDeleteRows = false;
            this.Reservation_GridView.AllowUserToOrderColumns = true;
            this.Reservation_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reservation_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservation_GridView.Location = new System.Drawing.Point(747, 365);
            this.Reservation_GridView.Name = "Reservation_GridView";
            this.Reservation_GridView.ReadOnly = true;
            this.Reservation_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Reservation_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Reservation_GridView.Size = new System.Drawing.Size(630, 329);
            this.Reservation_GridView.TabIndex = 24;
            this.Reservation_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reservation_GridView_CellContentClick);
            // 
            // gpbxReservationDetails
            // 
            this.gpbxReservationDetails.Controls.Add(this.txbxBoatname);
            this.gpbxReservationDetails.Controls.Add(this.btn_lock);
            this.gpbxReservationDetails.Controls.Add(this.txbxpricetotal);
            this.gpbxReservationDetails.Controls.Add(this.label8);
            this.gpbxReservationDetails.Controls.Add(this.txbxphone);
            this.gpbxReservationDetails.Controls.Add(this.label6);
            this.gpbxReservationDetails.Controls.Add(this.txbxaddress);
            this.gpbxReservationDetails.Controls.Add(this.label4);
            this.gpbxReservationDetails.Controls.Add(this.txbxname);
            this.gpbxReservationDetails.Controls.Add(this.Dateout);
            this.gpbxReservationDetails.Controls.Add(this.Datein);
            this.gpbxReservationDetails.Controls.Add(this.txbxReservationID);
            this.gpbxReservationDetails.Controls.Add(this.label7);
            this.gpbxReservationDetails.Controls.Add(this.label1);
            this.gpbxReservationDetails.Controls.Add(this.label2);
            this.gpbxReservationDetails.Controls.Add(this.label3);
            this.gpbxReservationDetails.Controls.Add(this.label5);
            this.gpbxReservationDetails.Location = new System.Drawing.Point(76, 319);
            this.gpbxReservationDetails.Name = "gpbxReservationDetails";
            this.gpbxReservationDetails.Size = new System.Drawing.Size(627, 490);
            this.gpbxReservationDetails.TabIndex = 25;
            this.gpbxReservationDetails.TabStop = false;
            this.gpbxReservationDetails.Text = "Reservation Details";
            // 
            // txbxBoatname
            // 
            this.txbxBoatname.Enabled = false;
            this.txbxBoatname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxBoatname.Location = new System.Drawing.Point(15, 154);
            this.txbxBoatname.Name = "txbxBoatname";
            this.txbxBoatname.Size = new System.Drawing.Size(199, 35);
            this.txbxBoatname.TabIndex = 33;
            // 
            // btn_lock
            // 
            this.btn_lock.Enabled = false;
            this.btn_lock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lock.FlatAppearance.BorderSize = 0;
            this.btn_lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_lock.Location = new System.Drawing.Point(388, 328);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(126, 75);
            this.btn_lock.TabIndex = 32;
            this.btn_lock.Text = "Lock Date";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbxpricetotal
            // 
            this.txbxpricetotal.Enabled = false;
            this.txbxpricetotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxpricetotal.Location = new System.Drawing.Point(388, 446);
            this.txbxpricetotal.Name = "txbxpricetotal";
            this.txbxpricetotal.Size = new System.Drawing.Size(136, 35);
            this.txbxpricetotal.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(207, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total Price(Eu)";
            // 
            // txbxphone
            // 
            this.txbxphone.Enabled = false;
            this.txbxphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxphone.Location = new System.Drawing.Point(201, 267);
            this.txbxphone.Name = "txbxphone";
            this.txbxphone.Size = new System.Drawing.Size(194, 35);
            this.txbxphone.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(19, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phone Number";
            // 
            // txbxaddress
            // 
            this.txbxaddress.Enabled = false;
            this.txbxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxaddress.Location = new System.Drawing.Point(15, 226);
            this.txbxaddress.Name = "txbxaddress";
            this.txbxaddress.Size = new System.Drawing.Size(531, 35);
            this.txbxaddress.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(10, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            // 
            // txbxname
            // 
            this.txbxname.Enabled = false;
            this.txbxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxname.Location = new System.Drawing.Point(15, 84);
            this.txbxname.Name = "txbxname";
            this.txbxname.Size = new System.Drawing.Size(199, 35);
            this.txbxname.TabIndex = 25;
            // 
            // Dateout
            // 
            this.Dateout.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.Enabled = false;
            this.Dateout.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.Location = new System.Drawing.Point(132, 366);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(250, 37);
            this.Dateout.TabIndex = 22;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // Datein
            // 
            this.Datein.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Datein.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Datein.Enabled = false;
            this.Datein.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datein.Location = new System.Drawing.Point(132, 320);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(250, 37);
            this.Datein.TabIndex = 21;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // txbxReservationID
            // 
            this.txbxReservationID.Enabled = false;
            this.txbxReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxReservationID.Location = new System.Drawing.Point(299, 23);
            this.txbxReservationID.Name = "txbxReservationID";
            this.txbxReservationID.Size = new System.Drawing.Size(87, 35);
            this.txbxReservationID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(15, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Boat Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated Reservation ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(34, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(19, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date Out";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Location = new System.Drawing.Point(633, 855);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(265, 102);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.Location = new System.Drawing.Point(76, 855);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(227, 102);
            this.btn_Edit.TabIndex = 30;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Enabled = false;
            this.btnconfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnconfirm.FlatAppearance.BorderSize = 0;
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnconfirm.Location = new System.Drawing.Point(366, 855);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(234, 102);
            this.btnconfirm.TabIndex = 32;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(1399, 969);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 64);
            this.button1.TabIndex = 33;
            this.button1.Text = "Back To Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txbxprice
            // 
            this.txbxprice.Enabled = false;
            this.txbxprice.Location = new System.Drawing.Point(359, 251);
            this.txbxprice.Name = "txbxprice";
            this.txbxprice.Size = new System.Drawing.Size(38, 20);
            this.txbxprice.TabIndex = 34;
            this.txbxprice.Visible = false;
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 1045);
            this.Controls.Add(this.txbxprice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbxReservationDetails);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.Reservation_GridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MyOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_GridView)).EndInit();
            this.gpbxReservationDetails.ResumeLayout(false);
            this.gpbxReservationDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientInformation;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Reservation_GridView;
        private System.Windows.Forms.GroupBox gpbxReservationDetails;
        private System.Windows.Forms.Button btn_lock;
        private System.Windows.Forms.TextBox txbxpricetotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbxphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxname;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.TextBox txbxReservationID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox txbxBoatname;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbxprice;
    }
}