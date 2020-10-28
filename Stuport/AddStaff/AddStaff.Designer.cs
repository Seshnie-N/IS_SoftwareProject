namespace Stuport
{
    partial class AddStaff
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddStaff = new System.Windows.Forms.Label();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(256, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 21);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(256, 184);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.TextBox3_TextChanged_1);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(256, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(78, 132);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(57, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(78, 106);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(79, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(78, 187);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(77, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(79, 213);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type";
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(82, 277);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(256, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblAddStaff
            // 
            this.lblAddStaff.AutoSize = true;
            this.lblAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStaff.Location = new System.Drawing.Point(145, 39);
            this.lblAddStaff.Name = "lblAddStaff";
            this.lblAddStaff.Size = new System.Drawing.Size(126, 31);
            this.lblAddStaff.TabIndex = 13;
            this.lblAddStaff.Text = "Add Staff";
            // 
            // cmbxType
            // 
            this.cmbxType.DisplayMember = "Academiv";
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Items.AddRange(new object[] {
            "Counsellor",
            "Academic"});
            this.cmbxType.Location = new System.Drawing.Point(256, 213);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(100, 21);
            this.cmbxType.TabIndex = 4;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 334);
            this.Controls.Add(this.cmbxType);
            this.Controls.Add(this.lblAddStaff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.IconOptions.Image = global::Stuport.Properties.Resources.IMG_20201027_190658_804_removebg_preview;
            this.Name = "AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Staff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddStaff;
        private System.Windows.Forms.ComboBox cmbxType;
    }
}