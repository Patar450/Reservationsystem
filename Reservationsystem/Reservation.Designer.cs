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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lblClientInformation = new System.Windows.Forms.Label();
            this.gpbxReservationDetails = new System.Windows.Forms.GroupBox();
            this.txbxReservationID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxBoatname = new System.Windows.Forms.TextBox();
            this.txbxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Reservation_GridView = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(1201, 100);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(997, 58);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(101, 42);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
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
            this.gpbxReservationDetails.Controls.Add(this.dateTimePicker2);
            this.gpbxReservationDetails.Controls.Add(this.dateTimePicker1);
            this.gpbxReservationDetails.Controls.Add(this.txbxReservationID);
            this.gpbxReservationDetails.Controls.Add(this.label7);
            this.gpbxReservationDetails.Controls.Add(this.label1);
            this.gpbxReservationDetails.Controls.Add(this.txbxBoatname);
            this.gpbxReservationDetails.Controls.Add(this.txbxClientName);
            this.gpbxReservationDetails.Controls.Add(this.label2);
            this.gpbxReservationDetails.Controls.Add(this.label3);
            this.gpbxReservationDetails.Controls.Add(this.label5);
            this.gpbxReservationDetails.Location = new System.Drawing.Point(34, 125);
            this.gpbxReservationDetails.Name = "gpbxReservationDetails";
            this.gpbxReservationDetails.Size = new System.Drawing.Size(336, 251);
            this.gpbxReservationDetails.TabIndex = 22;
            this.gpbxReservationDetails.TabStop = false;
            this.gpbxReservationDetails.Text = "Reservation Details";
            // 
            // txbxReservationID
            // 
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
            // txbxBoatname
            // 
            this.txbxBoatname.Location = new System.Drawing.Point(174, 95);
            this.txbxBoatname.Name = "txbxBoatname";
            this.txbxBoatname.Size = new System.Drawing.Size(136, 20);
            this.txbxBoatname.TabIndex = 19;
            // 
            // txbxClientName
            // 
            this.txbxClientName.Location = new System.Drawing.Point(6, 95);
            this.txbxClientName.Name = "txbxClientName";
            this.txbxClientName.Size = new System.Drawing.Size(136, 20);
            this.txbxClientName.TabIndex = 3;
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
            this.label3.Location = new System.Drawing.Point(16, 134);
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
            this.Reservation_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reservation_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservation_GridView.Location = new System.Drawing.Point(376, 125);
            this.Reservation_GridView.Name = "Reservation_GridView";
            this.Reservation_GridView.ReadOnly = true;
            this.Reservation_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Reservation_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Reservation_GridView.Size = new System.Drawing.Size(790, 329);
            this.Reservation_GridView.TabIndex = 23;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Location = new System.Drawing.Point(229, 401);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 38);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Edit.Location = new System.Drawing.Point(148, 401);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 38);
            this.btn_Edit.TabIndex = 27;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Location = new System.Drawing.Point(67, 401);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 26;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(76, 164);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 27);
            this.dateTimePicker2.TabIndex = 22;
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
            this.button1.Text = "Search by Boat";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(534, 475);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Free ",
            "Busy"});
            this.comboBox1.Location = new System.Drawing.Point(405, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 523);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Reservation_GridView);
            this.Controls.Add(this.gpbxReservationDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.Text = "Reservation";
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
        private System.Windows.Forms.TextBox txbxBoatname;
        private System.Windows.Forms.TextBox txbxClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Reservation_GridView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}