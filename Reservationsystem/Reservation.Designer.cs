namespace Reservationsystem
{
    partial class Reservation
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
            this.gpbxReservationDetails = new System.Windows.Forms.GroupBox();
            this.ComboBoat = new System.Windows.Forms.ComboBox();
            this.ComboClient = new System.Windows.Forms.ComboBox();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.txbxReservationID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Reservation_GridView = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbxReservationsearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbxPhone = new System.Windows.Forms.TextBox();
            this.txbxAddress = new System.Windows.Forms.TextBox();
            this.btn_Addnew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbxpricetotal = new System.Windows.Forms.TextBox();
            this.btn_lock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpbxReservationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1034, 100);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(820, 58);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(101, 42);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.Click += new System.EventHandler(this.lbl_Date_Click);
            // 
            // lblClientInformation
            // 
            this.lblClientInformation.AutoSize = true;
            this.lblClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInformation.Location = new System.Drawing.Point(27, 24);
            this.lblClientInformation.Name = "lblClientInformation";
            this.lblClientInformation.Size = new System.Drawing.Size(249, 42);
            this.lblClientInformation.TabIndex = 0;
            this.lblClientInformation.Text = "Reservations";
            // 
            // gpbxReservationDetails
            // 
            this.gpbxReservationDetails.Controls.Add(this.btn_lock);
            this.gpbxReservationDetails.Controls.Add(this.txbxpricetotal);
            this.gpbxReservationDetails.Controls.Add(this.label9);
            this.gpbxReservationDetails.Controls.Add(this.txbxAddress);
            this.gpbxReservationDetails.Controls.Add(this.txbxPhone);
            this.gpbxReservationDetails.Controls.Add(this.label8);
            this.gpbxReservationDetails.Controls.Add(this.label6);
            this.gpbxReservationDetails.Controls.Add(this.txbxprice);
            this.gpbxReservationDetails.Controls.Add(this.label4);
            this.gpbxReservationDetails.Controls.Add(this.ComboBoat);
            this.gpbxReservationDetails.Controls.Add(this.ComboClient);
            this.gpbxReservationDetails.Controls.Add(this.Dateout);
            this.gpbxReservationDetails.Controls.Add(this.Datein);
            this.gpbxReservationDetails.Controls.Add(this.txbxReservationID);
            this.gpbxReservationDetails.Controls.Add(this.label7);
            this.gpbxReservationDetails.Controls.Add(this.label1);
            this.gpbxReservationDetails.Controls.Add(this.label2);
            this.gpbxReservationDetails.Controls.Add(this.label3);
            this.gpbxReservationDetails.Controls.Add(this.label5);
            this.gpbxReservationDetails.Location = new System.Drawing.Point(34, 125);
            this.gpbxReservationDetails.Name = "gpbxReservationDetails";
            this.gpbxReservationDetails.Size = new System.Drawing.Size(336, 327);
            this.gpbxReservationDetails.TabIndex = 22;
            this.gpbxReservationDetails.TabStop = false;
            this.gpbxReservationDetails.Text = "Reservation Details";
            // 
            // ComboBoat
            // 
            this.ComboBoat.FormattingEnabled = true;
            this.ComboBoat.Items.AddRange(new object[] {
            ""});
            this.ComboBoat.Location = new System.Drawing.Point(174, 95);
            this.ComboBoat.Name = "ComboBoat";
            this.ComboBoat.Size = new System.Drawing.Size(136, 21);
            this.ComboBoat.TabIndex = 24;
            this.ComboBoat.SelectedIndexChanged += new System.EventHandler(this.ComboBoat_SelectedIndexChanged);
            // 
            // ComboClient
            // 
            this.ComboClient.FormattingEnabled = true;
            this.ComboClient.Location = new System.Drawing.Point(6, 95);
            this.ComboClient.Name = "ComboClient";
            this.ComboClient.Size = new System.Drawing.Size(136, 21);
            this.ComboClient.TabIndex = 23;
            this.ComboClient.SelectedIndexChanged += new System.EventHandler(this.ComboClient_SelectedIndexChanged);
            // 
            // Dateout
            // 
            this.Dateout.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.Location = new System.Drawing.Point(76, 164);
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
            this.Datein.Location = new System.Drawing.Point(76, 127);
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
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation ID";
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
            this.label3.Location = new System.Drawing.Point(3, 134);
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
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date Out";
            // 
            // Reservation_GridView
            // 
            this.Reservation_GridView.AllowUserToAddRows = false;
            this.Reservation_GridView.AllowUserToDeleteRows = false;
            this.Reservation_GridView.AllowUserToOrderColumns = true;
            this.Reservation_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Reservation_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reservation_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservation_GridView.Location = new System.Drawing.Point(376, 125);
            this.Reservation_GridView.Name = "Reservation_GridView";
            this.Reservation_GridView.ReadOnly = true;
            this.Reservation_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Reservation_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Reservation_GridView.Size = new System.Drawing.Size(630, 329);
            this.Reservation_GridView.TabIndex = 23;
            this.Reservation_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reservation_GridView_CellContentClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Location = new System.Drawing.Point(269, 457);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 38);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.Location = new System.Drawing.Point(156, 457);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 38);
            this.btn_Edit.TabIndex = 27;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Confirm.Location = new System.Drawing.Point(34, 457);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(95, 38);
            this.btn_Confirm.TabIndex = 26;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Visible = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Reservationsystem.Properties.Resources.refresh;
            this.pictureBox2.Location = new System.Drawing.Point(884, 470);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(711, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 26);
            this.button1.TabIndex = 33;
            this.button1.Text = "Search by Res_ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbxReservationsearch
            // 
            this.txbxReservationsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxReservationsearch.Location = new System.Drawing.Point(534, 475);
            this.txbxReservationsearch.Name = "txbxReservationsearch";
            this.txbxReservationsearch.Size = new System.Drawing.Size(171, 20);
            this.txbxReservationsearch.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(931, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 38);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Base Costs (Euro)";
            // 
            // txbxprice
            // 
            this.txbxprice.Enabled = false;
            this.txbxprice.Location = new System.Drawing.Point(141, 208);
            this.txbxprice.Name = "txbxprice";
            this.txbxprice.Size = new System.Drawing.Size(102, 20);
            this.txbxprice.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(3, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(3, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address:";
            // 
            // txbxPhone
            // 
            this.txbxPhone.Location = new System.Drawing.Point(75, 242);
            this.txbxPhone.Name = "txbxPhone";
            this.txbxPhone.Size = new System.Drawing.Size(102, 20);
            this.txbxPhone.TabIndex = 29;
            // 
            // txbxAddress
            // 
            this.txbxAddress.Location = new System.Drawing.Point(75, 270);
            this.txbxAddress.Name = "txbxAddress";
            this.txbxAddress.Size = new System.Drawing.Size(226, 20);
            this.txbxAddress.TabIndex = 30;
            // 
            // btn_Addnew
            // 
            this.btn_Addnew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Addnew.FlatAppearance.BorderSize = 0;
            this.btn_Addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addnew.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Addnew.Location = new System.Drawing.Point(34, 457);
            this.btn_Addnew.Name = "btn_Addnew";
            this.btn_Addnew.Size = new System.Drawing.Size(101, 38);
            this.btn_Addnew.TabIndex = 37;
            this.btn_Addnew.Text = "Add New";
            this.btn_Addnew.UseVisualStyleBackColor = true;
            this.btn_Addnew.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(6, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "TotalCosts:";
            // 
            // txbxpricetotal
            // 
            this.txbxpricetotal.Enabled = false;
            this.txbxpricetotal.Location = new System.Drawing.Point(95, 297);
            this.txbxpricetotal.Name = "txbxpricetotal";
            this.txbxpricetotal.Size = new System.Drawing.Size(148, 20);
            this.txbxpricetotal.TabIndex = 32;
            // 
            // btn_lock
            // 
            this.btn_lock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lock.FlatAppearance.BorderSize = 0;
            this.btn_lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_lock.Location = new System.Drawing.Point(260, 134);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(59, 52);
            this.btn_lock.TabIndex = 33;
            this.btn_lock.Text = "Lock Date";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 523);
            this.Controls.Add(this.btn_Addnew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbxReservationsearch);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.Reservation_GridView);
            this.Controls.Add(this.gpbxReservationDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbxReservationDetails.ResumeLayout(false);
            this.gpbxReservationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lblClientInformation;
        private System.Windows.Forms.GroupBox gpbxReservationDetails;
        private System.Windows.Forms.TextBox txbxReservationID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Reservation_GridView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbxReservationsearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox ComboBoat;
        private System.Windows.Forms.ComboBox ComboClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbxprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxAddress;
        private System.Windows.Forms.TextBox txbxPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Addnew;
        private System.Windows.Forms.TextBox txbxpricetotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_lock;
    }
}