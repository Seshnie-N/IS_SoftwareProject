namespace Stuport
{
    partial class StudentRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.txtPasswordConf = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttHints = new System.Windows.Forms.ToolTip(this.components);
            this.lblStudNum = new System.Windows.Forms.Label();
            this.txtStudNum = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter The Following Details To Create A #Stuport Account ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(88, 148);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(204, 20);
            this.txtFName.TabIndex = 2;
            this.ttHints.SetToolTip(this.txtFName, "Enter Legal First Name. No Nicknames");
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(85, 132);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(85, 181);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 4;
            this.ttHints.SetToolTip(this.txtEmail, "Enter a Valid Email Address");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(85, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email Address";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(88, 197);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(204, 20);
            this.txtLName.TabIndex = 3;
            this.ttHints.SetToolTip(this.txtLName, "Enter Last Name ");
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(85, 280);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNo.TabIndex = 8;
            this.lblPhoneNo.Text = "Contact Number";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Location = new System.Drawing.Point(85, 330);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(53, 13);
            this.lblPassword1.TabIndex = 10;
            this.lblPassword1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 346);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 6;
            this.ttHints.SetToolTip(this.txtPassword, "Password must be 8 or more characters. Must contain an uppercase character and a " +
        "lowercase character.");
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(85, 383);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(91, 13);
            this.lblPassword2.TabIndex = 12;
            this.lblPassword2.Text = "Confirm Password";
            this.lblPassword2.Click += new System.EventHandler(this.lblPassword2_Click);
            // 
            // txtPasswordConf
            // 
            this.txtPasswordConf.Location = new System.Drawing.Point(88, 399);
            this.txtPasswordConf.Name = "txtPasswordConf";
            this.txtPasswordConf.Size = new System.Drawing.Size(204, 20);
            this.txtPasswordConf.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(137, 439);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ttHints
            // 
            this.ttHints.Popup += new System.Windows.Forms.PopupEventHandler(this.TtHints_Popup);
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStudNum.Location = new System.Drawing.Point(85, 80);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(84, 13);
            this.lblStudNum.TabIndex = 15;
            this.lblStudNum.Text = "Student Number";
            // 
            // txtStudNum
            // 
            this.txtStudNum.Location = new System.Drawing.Point(88, 97);
            this.txtStudNum.Name = "txtStudNum";
            this.txtStudNum.Size = new System.Drawing.Size(204, 20);
            this.txtStudNum.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 296);
            this.txtPhone.Mask = "000 000 0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 20);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 508);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtStudNum);
            this.Controls.Add(this.lblStudNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.txtPasswordConf);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label1);
            this.Name = "StudentRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.TextBox txtPasswordConf;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttHints;
        private System.Windows.Forms.Label lblStudNum;
        private System.Windows.Forms.TextBox txtStudNum;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}