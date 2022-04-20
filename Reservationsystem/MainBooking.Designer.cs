namespace Reservationsystem
{
    partial class MainBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.Staffpic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Client_Details = new System.Windows.Forms.Button();
            this.btn_Boat_Details = new System.Windows.Forms.Button();
            this.btn_Staff_Details = new System.Windows.Forms.Button();
            this.btn_Reservation_Details = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Staffpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Form";
            // 
            // Staffpic
            // 
            this.Staffpic.Image = global::Reservationsystem.Properties.Resources.employees;
            this.Staffpic.Location = new System.Drawing.Point(628, 44);
            this.Staffpic.Name = "Staffpic";
            this.Staffpic.Size = new System.Drawing.Size(78, 80);
            this.Staffpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Staffpic.TabIndex = 1;
            this.Staffpic.TabStop = false;
            this.Staffpic.Click += new System.EventHandler(this.Staffpic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome Admin!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "What would you like to do?";
            // 
            // btn_Client_Details
            // 
            this.btn_Client_Details.Enabled = false;
            this.btn_Client_Details.Location = new System.Drawing.Point(110, 236);
            this.btn_Client_Details.Name = "btn_Client_Details";
            this.btn_Client_Details.Size = new System.Drawing.Size(135, 41);
            this.btn_Client_Details.TabIndex = 4;
            this.btn_Client_Details.Text = "Edit Client Details";
            this.btn_Client_Details.UseVisualStyleBackColor = true;
            // 
            // btn_Boat_Details
            // 
            this.btn_Boat_Details.Enabled = false;
            this.btn_Boat_Details.Location = new System.Drawing.Point(110, 369);
            this.btn_Boat_Details.Name = "btn_Boat_Details";
            this.btn_Boat_Details.Size = new System.Drawing.Size(135, 40);
            this.btn_Boat_Details.TabIndex = 5;
            this.btn_Boat_Details.Text = "Edit Boat Details";
            this.btn_Boat_Details.UseVisualStyleBackColor = true;
            this.btn_Boat_Details.Click += new System.EventHandler(this.btn_Boat_Details_Click);
            // 
            // btn_Staff_Details
            // 
            this.btn_Staff_Details.Enabled = false;
            this.btn_Staff_Details.Location = new System.Drawing.Point(365, 237);
            this.btn_Staff_Details.Name = "btn_Staff_Details";
            this.btn_Staff_Details.Size = new System.Drawing.Size(135, 40);
            this.btn_Staff_Details.TabIndex = 6;
            this.btn_Staff_Details.Text = "Edit Staff Details";
            this.btn_Staff_Details.UseVisualStyleBackColor = true;

            // 
            // btn_Reservation_Details
            // 
            this.btn_Reservation_Details.Location = new System.Drawing.Point(365, 369);
            this.btn_Reservation_Details.Name = "btn_Reservation_Details";
            this.btn_Reservation_Details.Size = new System.Drawing.Size(135, 40);
            this.btn_Reservation_Details.TabIndex = 7;
            this.btn_Reservation_Details.Text = "Edit Reservation Details";
            this.btn_Reservation_Details.UseVisualStyleBackColor = true;
            this.btn_Reservation_Details.Click += new System.EventHandler(this.btn_Reservation_Details_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservationsystem.Properties.Resources.id_card;
            this.pictureBox1.Location = new System.Drawing.Point(391, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reservationsystem.Properties.Resources.speed_boat;
            this.pictureBox2.Location = new System.Drawing.Point(139, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = global::Reservationsystem.Properties.Resources.rating;
            this.pictureBox3.Location = new System.Drawing.Point(139, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Reservationsystem.Properties.Resources.booking;
            this.pictureBox4.Location = new System.Drawing.Point(391, 283);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(728, 398);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(60, 40);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Reservationsystem.Properties.Resources.log_out;
            this.pictureBox5.Location = new System.Drawing.Point(742, 364);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(742, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(46, 23);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "<-- Future updates -->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "<-- Future update";
            // 
            // MainBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Reservation_Details);
            this.Controls.Add(this.btn_Staff_Details);
            this.Controls.Add(this.btn_Boat_Details);
            this.Controls.Add(this.btn_Client_Details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Staffpic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainBooking";
            ((System.ComponentModel.ISupportInitialize)(this.Staffpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Staffpic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Client_Details;
        private System.Windows.Forms.Button btn_Boat_Details;
        private System.Windows.Forms.Button btn_Staff_Details;
        private System.Windows.Forms.Button btn_Reservation_Details;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}