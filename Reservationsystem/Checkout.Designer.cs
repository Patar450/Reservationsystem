namespace Reservationsystem
{
    partial class Checkout
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
            this.lblClientInformation = new System.Windows.Forms.Label();
            this.gpbxReservationDetails = new System.Windows.Forms.GroupBox();
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
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txbxBoatname = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpbxReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblClientInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblClientInformation
            // 
            this.lblClientInformation.AutoSize = true;
            this.lblClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInformation.Location = new System.Drawing.Point(27, 24);
            this.lblClientInformation.Name = "lblClientInformation";
            this.lblClientInformation.Size = new System.Drawing.Size(185, 42);
            this.lblClientInformation.TabIndex = 0;
            this.lblClientInformation.Text = "Checkout";
            // 
            // gpbxReservationDetails
            // 
            this.gpbxReservationDetails.Controls.Add(this.button1);
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
            this.gpbxReservationDetails.Location = new System.Drawing.Point(34, 141);
            this.gpbxReservationDetails.Name = "gpbxReservationDetails";
            this.gpbxReservationDetails.Size = new System.Drawing.Size(360, 325);
            this.gpbxReservationDetails.TabIndex = 23;
            this.gpbxReservationDetails.TabStop = false;
            this.gpbxReservationDetails.Text = "Reservation Details";
            // 
            // txbxpricetotal
            // 
            this.txbxpricetotal.Enabled = false;
            this.txbxpricetotal.Location = new System.Drawing.Point(174, 183);
            this.txbxpricetotal.Name = "txbxpricetotal";
            this.txbxpricetotal.Size = new System.Drawing.Size(136, 20);
            this.txbxpricetotal.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(171, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total Price(Eu)";
            // 
            // txbxphone
            // 
            this.txbxphone.Enabled = false;
            this.txbxphone.Location = new System.Drawing.Point(6, 183);
            this.txbxphone.Name = "txbxphone";
            this.txbxphone.Size = new System.Drawing.Size(129, 20);
            this.txbxphone.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(8, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phone Number";
            // 
            // txbxaddress
            // 
            this.txbxaddress.Enabled = false;
            this.txbxaddress.Location = new System.Drawing.Point(9, 139);
            this.txbxaddress.Name = "txbxaddress";
            this.txbxaddress.Size = new System.Drawing.Size(301, 20);
            this.txbxaddress.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            // 
            // txbxname
            // 
            this.txbxname.Enabled = false;
            this.txbxname.Location = new System.Drawing.Point(6, 95);
            this.txbxname.Name = "txbxname";
            this.txbxname.Size = new System.Drawing.Size(129, 20);
            this.txbxname.TabIndex = 25;
            // 
            // Dateout
            // 
            this.Dateout.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.Location = new System.Drawing.Point(76, 271);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(178, 27);
            this.Dateout.TabIndex = 22;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // Datein
            // 
            this.Datein.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Datein.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Datein.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datein.Location = new System.Drawing.Point(76, 227);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(178, 27);
            this.Datein.TabIndex = 21;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // txbxReservationID
            // 
            this.txbxReservationID.Enabled = false;
            this.txbxReservationID.Location = new System.Drawing.Point(6, 44);
            this.txbxReservationID.Name = "txbxReservationID";
            this.txbxReservationID.Size = new System.Drawing.Size(304, 20);
            this.txbxReservationID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(171, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Boat Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated Reservation ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(16, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(3, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date Out";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Location = new System.Drawing.Point(29, 472);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 38);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_confirm.Location = new System.Drawing.Point(281, 472);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(89, 38);
            this.btn_confirm.TabIndex = 29;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txbxBoatname
            // 
            this.txbxBoatname.Enabled = false;
            this.txbxBoatname.Location = new System.Drawing.Point(208, 236);
            this.txbxBoatname.Name = "txbxBoatname";
            this.txbxBoatname.Size = new System.Drawing.Size(136, 20);
            this.txbxBoatname.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(260, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 52);
            this.button1.TabIndex = 32;
            this.button1.Text = "Lock Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 538);
            this.Controls.Add(this.txbxBoatname);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.gpbxReservationDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbxReservationDetails.ResumeLayout(false);
            this.gpbxReservationDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientInformation;
        private System.Windows.Forms.GroupBox gpbxReservationDetails;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.TextBox txbxReservationID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxname;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txbxBoatname;
        private System.Windows.Forms.TextBox txbxpricetotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}