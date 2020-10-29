using System;
using System.Windows.Forms;

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
            this.lblLogin = new System.Windows.Forms.Label();
            this.minimizelbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(85, 188);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(204, 20);
            this.txtFName.TabIndex = 2;
            this.ttHints.SetToolTip(this.txtFName, "Enter Legal First Name. No Nicknames");
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblFName.Location = new System.Drawing.Point(82, 167);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(70, 17);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblLName.Location = new System.Drawing.Point(82, 216);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(74, 17);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 4;
            this.ttHints.SetToolTip(this.txtEmail, "Enter a Valid Email Address");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblEmail.Location = new System.Drawing.Point(82, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email Address";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(85, 237);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(204, 20);
            this.txtLName.TabIndex = 3;
            this.ttHints.SetToolTip(this.txtLName, "Enter Last Name ");
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblPhoneNo.Location = new System.Drawing.Point(82, 315);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(108, 17);
            this.lblPhoneNo.TabIndex = 8;
            this.lblPhoneNo.Text = "Contact Number";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblPassword1.Location = new System.Drawing.Point(82, 365);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(63, 17);
            this.lblPassword1.TabIndex = 10;
            this.lblPassword1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 386);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 6;
            this.ttHints.SetToolTip(this.txtPassword, "Password must be 8 or more characters. Must contain an uppercase character and a " +
        "lowercase character.");
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblPassword2.Location = new System.Drawing.Point(82, 418);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(112, 17);
            this.lblPassword2.TabIndex = 12;
            this.lblPassword2.Text = "Confirm Password";
            // 
            // txtPasswordConf
            // 
            this.txtPasswordConf.Location = new System.Drawing.Point(85, 439);
            this.txtPasswordConf.Name = "txtPasswordConf";
            this.txtPasswordConf.PasswordChar = '*';
            this.txtPasswordConf.Size = new System.Drawing.Size(204, 20);
            this.txtPasswordConf.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnRegister.Location = new System.Drawing.Point(200, 509);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 27);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnCancel.Location = new System.Drawing.Point(66, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.lblStudNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblStudNum.Location = new System.Drawing.Point(82, 115);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(105, 17);
            this.lblStudNum.TabIndex = 15;
            this.lblStudNum.Text = "Student Number";
            // 
            // txtStudNum
            // 
            this.txtStudNum.Location = new System.Drawing.Point(85, 137);
            this.txtStudNum.Name = "txtStudNum";
            this.txtStudNum.Size = new System.Drawing.Size(204, 20);
            this.txtStudNum.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(85, 336);
            this.txtPhone.Mask = "000 000 0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblLogin.Location = new System.Drawing.Point(54, 60);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(290, 33);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "R E G I S T R A T I O N";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.minimizelbl.Location = new System.Drawing.Point(337, 9);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(16, 17);
            this.minimizelbl.TabIndex = 18;
            this.minimizelbl.Text = "_";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.exitlbl.Location = new System.Drawing.Point(359, 9);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(17, 17);
            this.exitlbl.TabIndex = 17;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(388, 567);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.lblLogin);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
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
        private Label lblLogin;
        private Label minimizelbl;
        private Label exitlbl;
    }
}