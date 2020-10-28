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
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizelbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.btnManageAppointments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 397);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 26);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(168, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "A D M I N  M E N U";
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.BackColor = System.Drawing.Color.Transparent;
            this.minimizelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.minimizelbl.Location = new System.Drawing.Point(529, 7);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(17, 19);
            this.minimizelbl.TabIndex = 17;
            this.minimizelbl.Text = "_";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.exitlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.exitlbl.Location = new System.Drawing.Point(555, 9);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(20, 19);
            this.exitlbl.TabIndex = 16;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Stuport.Properties.Resources.WeeklyReportBtn;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(490, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 65);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.BackColor = System.Drawing.Color.White;
            this.btnManageStudents.BackgroundImage = global::Stuport.Properties.Resources.ManageStudentsBtn;
            this.btnManageStudents.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudents.Location = new System.Drawing.Point(126, 235);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(165, 65);
            this.btnManageStudents.TabIndex = 4;
            this.btnManageStudents.UseVisualStyleBackColor = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.BackColor = System.Drawing.Color.White;
            this.btnManageStaff.BackgroundImage = global::Stuport.Properties.Resources.ManageStaffBtn;
            this.btnManageStaff.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.Location = new System.Drawing.Point(342, 235);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(115, 65);
            this.btnManageStaff.TabIndex = 3;
            this.btnManageStaff.UseVisualStyleBackColor = false;
            this.btnManageStaff.Click += new System.EventHandler(this.BtnManageStaff_Click);
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.BackColor = System.Drawing.Color.White;
            this.btnManageGroups.BackgroundImage = global::Stuport.Properties.Resources.ManageGroupsBtn;
            this.btnManageGroups.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGroups.Location = new System.Drawing.Point(292, 130);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(165, 65);
            this.btnManageGroups.TabIndex = 2;
            this.btnManageGroups.UseVisualStyleBackColor = false;
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.BackColor = System.Drawing.Color.White;
            this.btnManageAppointments.BackgroundImage = global::Stuport.Properties.Resources.ManageAppointmentBtn;
            this.btnManageAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAppointments.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAppointments.Location = new System.Drawing.Point(126, 130);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(115, 65);
            this.btnManageAppointments.TabIndex = 1;
            this.btnManageAppointments.UseVisualStyleBackColor = false;
            this.btnManageAppointments.Click += new System.EventHandler(this.btnManageAppointments_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(3)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(587, 433);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.btnManageStaff);
            this.Controls.Add(this.btnManageGroups);
            this.Controls.Add(this.btnManageAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageAppointments;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minimizelbl;
        private System.Windows.Forms.Label exitlbl;
    }
}