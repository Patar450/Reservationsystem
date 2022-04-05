namespace Reservationsystem
{
    partial class Staff
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
            this.gpbxClientDetails = new System.Windows.Forms.GroupBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txbxStaffID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxStaffName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxStaffPhone = new System.Windows.Forms.TextBox();
            this.txbxStaffPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxStaffUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Staff_GridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtbx_StaffSearch = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gpbxClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_GridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1167, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(887, 58);
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
            this.lblClientInformation.Size = new System.Drawing.Size(305, 42);
            this.lblClientInformation.TabIndex = 0;
            this.lblClientInformation.Text = "Staff Information";
            // 
            // gpbxClientDetails
            // 
            this.gpbxClientDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gpbxClientDetails.Controls.Add(this.comboGender);
            this.gpbxClientDetails.Controls.Add(this.txbxStaffID);
            this.gpbxClientDetails.Controls.Add(this.label7);
            this.gpbxClientDetails.Controls.Add(this.label1);
            this.gpbxClientDetails.Controls.Add(this.txbxStaffName);
            this.gpbxClientDetails.Controls.Add(this.label6);
            this.gpbxClientDetails.Controls.Add(this.txbxStaffPhone);
            this.gpbxClientDetails.Controls.Add(this.txbxStaffPassword);
            this.gpbxClientDetails.Controls.Add(this.label2);
            this.gpbxClientDetails.Controls.Add(this.label3);
            this.gpbxClientDetails.Controls.Add(this.txbxStaffUser);
            this.gpbxClientDetails.Controls.Add(this.label5);
            this.gpbxClientDetails.Location = new System.Drawing.Point(12, 106);
            this.gpbxClientDetails.Name = "gpbxClientDetails";
            this.gpbxClientDetails.Size = new System.Drawing.Size(336, 327);
            this.gpbxClientDetails.TabIndex = 22;
            this.gpbxClientDetails.TabStop = false;
            this.gpbxClientDetails.Text = "Staff Details";
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboGender.Location = new System.Drawing.Point(9, 139);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(121, 21);
            this.comboGender.Sorted = true;
            this.comboGender.TabIndex = 21;
            // 
            // txbxStaffID
            // 
            this.txbxStaffID.Location = new System.Drawing.Point(6, 44);
            this.txbxStaffID.Name = "txbxStaffID";
            this.txbxStaffID.Size = new System.Drawing.Size(304, 20);
            this.txbxStaffID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Staff Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff ID";
            // 
            // txbxStaffName
            // 
            this.txbxStaffName.Location = new System.Drawing.Point(6, 95);
            this.txbxStaffName.Name = "txbxStaffName";
            this.txbxStaffName.Size = new System.Drawing.Size(136, 20);
            this.txbxStaffName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(8, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Staff Password";
            // 
            // txbxStaffPhone
            // 
            this.txbxStaffPhone.Location = new System.Drawing.Point(8, 188);
            this.txbxStaffPhone.Name = "txbxStaffPhone";
            this.txbxStaffPhone.Size = new System.Drawing.Size(304, 20);
            this.txbxStaffPhone.TabIndex = 4;
            // 
            // txbxStaffPassword
            // 
            this.txbxStaffPassword.Location = new System.Drawing.Point(8, 284);
            this.txbxStaffPassword.Name = "txbxStaffPassword";
            this.txbxStaffPassword.Size = new System.Drawing.Size(304, 20);
            this.txbxStaffPassword.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(5, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Staff Phone Number";
            // 
            // txbxStaffUser
            // 
            this.txbxStaffUser.Location = new System.Drawing.Point(8, 236);
            this.txbxStaffUser.Name = "txbxStaffUser";
            this.txbxStaffUser.Size = new System.Drawing.Size(304, 20);
            this.txbxStaffUser.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(8, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Staff Username";
            // 
            // Staff_GridView
            // 
            this.Staff_GridView.AllowUserToAddRows = false;
            this.Staff_GridView.AllowUserToDeleteRows = false;
            this.Staff_GridView.AllowUserToOrderColumns = true;
            this.Staff_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staff_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_GridView.Location = new System.Drawing.Point(354, 106);
            this.Staff_GridView.Name = "Staff_GridView";
            this.Staff_GridView.ReadOnly = true;
            this.Staff_GridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Staff_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Staff_GridView.Size = new System.Drawing.Size(762, 329);
            this.Staff_GridView.TabIndex = 23;
            this.Staff_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_GridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Reservationsystem.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(705, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(544, 452);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 26);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.Text = "Search by Name";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtbx_StaffSearch
            // 
            this.txtbx_StaffSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbx_StaffSearch.Location = new System.Drawing.Point(367, 457);
            this.txtbx_StaffSearch.Name = "txtbx_StaffSearch";
            this.txtbx_StaffSearch.Size = new System.Drawing.Size(171, 20);
            this.txtbx_StaffSearch.TabIndex = 25;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Location = new System.Drawing.Point(185, 444);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 38);
            this.btn_Delete.TabIndex = 30;
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
            this.btn_Edit.Location = new System.Drawing.Point(104, 444);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 38);
            this.btn_Edit.TabIndex = 29;
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
            this.btn_Add.Location = new System.Drawing.Point(23, 444);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1167, 511);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtbx_StaffSearch);
            this.Controls.Add(this.Staff_GridView);
            this.Controls.Add(this.gpbxClientDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbxClientDetails.ResumeLayout(false);
            this.gpbxClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lblClientInformation;
        private System.Windows.Forms.GroupBox gpbxClientDetails;
        private System.Windows.Forms.TextBox txbxStaffID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxStaffName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxStaffPhone;
        private System.Windows.Forms.TextBox txbxStaffPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxStaffUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.DataGridView Staff_GridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtbx_StaffSearch;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Timer timer1;
    }
}