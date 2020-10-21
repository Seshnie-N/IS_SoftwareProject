namespace Stuport
{
    partial class AdminMenu
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
            this.btnManageAppointments = new System.Windows.Forms.Button();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.Location = new System.Drawing.Point(85, 54);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(165, 36);
            this.btnManageAppointments.TabIndex = 1;
            this.btnManageAppointments.Text = "Manage Appointments";
            this.btnManageAppointments.UseVisualStyleBackColor = true;
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.Location = new System.Drawing.Point(85, 112);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(165, 36);
            this.btnManageGroups.TabIndex = 2;
            this.btnManageGroups.Text = "Manage Groups";
            this.btnManageGroups.UseVisualStyleBackColor = true;
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Location = new System.Drawing.Point(85, 171);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(165, 36);
            this.btnManageStaff.TabIndex = 3;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.Click += new System.EventHandler(this.BtnManageStaff_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(85, 229);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(165, 36);
            this.btnManageStudents.TabIndex = 4;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 308);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 343);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.btnManageStaff);
            this.Controls.Add(this.btnManageGroups);
            this.Controls.Add(this.btnManageAppointments);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageAppointments;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnLogout;
    }
}