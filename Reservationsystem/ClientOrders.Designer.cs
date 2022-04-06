namespace Reservationsystem
{
    partial class ClientOrders
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
            this.Reservation_GridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxReservationID = new System.Windows.Forms.TextBox();
            this.gpbxClientDetails = new System.Windows.Forms.GroupBox();
            this.richreview = new System.Windows.Forms.RichTextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtbx_ReservationSearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoat = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_GridView)).BeginInit();
            this.gpbxClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1219, 100);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(1066, 58);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(101, 42);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lblClientInformation
            // 
            this.lblClientInformation.AutoSize = true;
            this.lblClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInformation.Location = new System.Drawing.Point(80, 33);
            this.lblClientInformation.Name = "lblClientInformation";
            this.lblClientInformation.Size = new System.Drawing.Size(232, 42);
            this.lblClientInformation.TabIndex = 0;
            this.lblClientInformation.Text = "Your Orders";
            this.lblClientInformation.Click += new System.EventHandler(this.lblClientInformation_Click);
            // 
            // Reservation_GridView
            // 
            this.Reservation_GridView.AllowUserToAddRows = false;
            this.Reservation_GridView.AllowUserToDeleteRows = false;
            this.Reservation_GridView.AllowUserToOrderColumns = true;
            this.Reservation_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reservation_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservation_GridView.Location = new System.Drawing.Point(370, 123);
            this.Reservation_GridView.Name = "Reservation_GridView";
            this.Reservation_GridView.ReadOnly = true;
            this.Reservation_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Reservation_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Reservation_GridView.Size = new System.Drawing.Size(837, 329);
            this.Reservation_GridView.TabIndex = 23;
            this.Reservation_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reservation_GridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Boat Name";
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
            // txbxClientName
            // 
            this.txbxClientName.Location = new System.Drawing.Point(6, 95);
            this.txbxClientName.Name = "txbxClientName";
            this.txbxClientName.Size = new System.Drawing.Size(136, 20);
            this.txbxClientName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Review from previous owner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ReservationID";
            // 
            // txbxReservationID
            // 
            this.txbxReservationID.Enabled = false;
            this.txbxReservationID.Location = new System.Drawing.Point(6, 44);
            this.txbxReservationID.Name = "txbxReservationID";
            this.txbxReservationID.Size = new System.Drawing.Size(136, 20);
            this.txbxReservationID.TabIndex = 1;
            // 
            // gpbxClientDetails
            // 
            this.gpbxClientDetails.Controls.Add(this.ComboBoat);
            this.gpbxClientDetails.Controls.Add(this.Dateout);
            this.gpbxClientDetails.Controls.Add(this.Datein);
            this.gpbxClientDetails.Controls.Add(this.label4);
            this.gpbxClientDetails.Controls.Add(this.label5);
            this.gpbxClientDetails.Controls.Add(this.richreview);
            this.gpbxClientDetails.Controls.Add(this.txbxReservationID);
            this.gpbxClientDetails.Controls.Add(this.label1);
            this.gpbxClientDetails.Controls.Add(this.label6);
            this.gpbxClientDetails.Controls.Add(this.txbxClientName);
            this.gpbxClientDetails.Controls.Add(this.label2);
            this.gpbxClientDetails.Controls.Add(this.label3);
            this.gpbxClientDetails.Location = new System.Drawing.Point(28, 123);
            this.gpbxClientDetails.Name = "gpbxClientDetails";
            this.gpbxClientDetails.Size = new System.Drawing.Size(336, 329);
            this.gpbxClientDetails.TabIndex = 24;
            this.gpbxClientDetails.TabStop = false;
            this.gpbxClientDetails.Text = "Client Details";
            // 
            // richreview
            // 
            this.richreview.Location = new System.Drawing.Point(9, 195);
            this.richreview.Name = "richreview";
            this.richreview.Size = new System.Drawing.Size(301, 128);
            this.richreview.TabIndex = 19;
            this.richreview.Text = "";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Location = new System.Drawing.Point(219, 458);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 38);
            this.btn_Delete.TabIndex = 27;
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
            this.btn_Edit.Location = new System.Drawing.Point(138, 458);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 38);
            this.btn_Edit.TabIndex = 26;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Location = new System.Drawing.Point(57, 458);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(1132, 458);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 38);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Reservationsystem.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(662, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(547, 465);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(109, 26);
            this.btn_Search.TabIndex = 33;
            this.btn_Search.Text = "Search by ID";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txtbx_ReservationSearch
            // 
            this.txtbx_ReservationSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbx_ReservationSearch.Location = new System.Drawing.Point(370, 470);
            this.txtbx_ReservationSearch.Name = "txtbx_ReservationSearch";
            this.txtbx_ReservationSearch.Size = new System.Drawing.Size(171, 20);
            this.txtbx_ReservationSearch.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dateout
            // 
            this.Dateout.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Dateout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateout.Location = new System.Drawing.Point(152, 122);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(178, 27);
            this.Dateout.TabIndex = 26;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // Datein
            // 
            this.Datein.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.Datein.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.Datein.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datein.Location = new System.Drawing.Point(152, 55);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(178, 27);
            this.Datein.TabIndex = 25;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(148, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(149, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date Out";
            // 
            // ComboBoat
            // 
            this.ComboBoat.FormattingEnabled = true;
            this.ComboBoat.Location = new System.Drawing.Point(9, 151);
            this.ComboBoat.Name = "ComboBoat";
            this.ComboBoat.Size = new System.Drawing.Size(133, 21);
            this.ComboBoat.TabIndex = 27;
            // 
            // ClientOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 502);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtbx_ReservationSearch);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gpbxClientDetails);
            this.Controls.Add(this.Reservation_GridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientOrders";
            this.Text = "ClientOrders";
            this.Load += new System.EventHandler(this.ClientOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_GridView)).EndInit();
            this.gpbxClientDetails.ResumeLayout(false);
            this.gpbxClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lblClientInformation;
        private System.Windows.Forms.DataGridView Reservation_GridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxReservationID;
        private System.Windows.Forms.GroupBox gpbxClientDetails;
        private System.Windows.Forms.RichTextBox richreview;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtbx_ReservationSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoat;
    }
}