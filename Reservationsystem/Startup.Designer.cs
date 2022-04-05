namespace Reservationsystem
{
    partial class Startup
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
            this.label3 = new System.Windows.Forms.Label();
            this.Progbar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(415, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblClientInformation
            // 
            this.lblClientInformation.AutoSize = true;
            this.lblClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInformation.Location = new System.Drawing.Point(9, 31);
            this.lblClientInformation.Name = "lblClientInformation";
            this.lblClientInformation.Size = new System.Drawing.Size(394, 42);
            this.lblClientInformation.TabIndex = 0;
            this.lblClientInformation.Text = "Boat Booking System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(32, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Created by Patrick Frendo";
            // 
            // Progbar
            // 
            this.Progbar.Location = new System.Drawing.Point(71, 167);
            this.Progbar.Name = "Progbar";
            this.Progbar.Size = new System.Drawing.Size(248, 40);
            this.Progbar.TabIndex = 8;
            this.Progbar.Click += new System.EventHandler(this.Progbar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 335);
            this.Controls.Add(this.Progbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Progbar;
        private System.Windows.Forms.Timer timer1;
    }
}