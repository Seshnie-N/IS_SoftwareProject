namespace StuportApp
{
    partial class StudentMenu
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
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnOtherServices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppointments
            // 
            this.btnAppointments.Location = new System.Drawing.Point(61, 102);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(165, 36);
            this.btnAppointments.TabIndex = 0;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            // 
            // btnOtherServices
            // 
            this.btnOtherServices.Location = new System.Drawing.Point(61, 156);
            this.btnOtherServices.Name = "btnOtherServices";
            this.btnOtherServices.Size = new System.Drawing.Size(165, 36);
            this.btnOtherServices.TabIndex = 1;
            this.btnOtherServices.Text = "Other Services";
            this.btnOtherServices.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select One Of The Following Options To Continue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome To #Stuport ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 275);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(61, 212);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(165, 36);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 313);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtherServices);
            this.Controls.Add(this.btnAppointments);
            this.Name = "StudentMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnOtherServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
    }
}

