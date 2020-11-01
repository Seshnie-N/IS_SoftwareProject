namespace Stuport
{
    partial class StudentProfile
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.stdnumlbl = new System.Windows.Forms.Label();
            this.fnlbl = new System.Windows.Forms.Label();
            this.lnlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.phnumlbl = new System.Windows.Forms.Label();
            this.stdnumtb = new System.Windows.Forms.TextBox();
            this.fntb = new System.Windows.Forms.TextBox();
            this.lntb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.phnumtb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.stuportDatabaseDataSet = new Stuport.StuportDatabaseDataSet();
            this.stuportDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minimizelbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.titlelbl.Location = new System.Drawing.Point(104, 16);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(137, 33);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "P r o f i l e";
            // 
            // stdnumlbl
            // 
            this.stdnumlbl.AutoSize = true;
            this.stdnumlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdnumlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.stdnumlbl.Location = new System.Drawing.Point(42, 75);
            this.stdnumlbl.Name = "stdnumlbl";
            this.stdnumlbl.Size = new System.Drawing.Size(88, 17);
            this.stdnumlbl.TabIndex = 1;
            this.stdnumlbl.Text = "Student No.:";
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.fnlbl.Location = new System.Drawing.Point(42, 114);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(75, 17);
            this.fnlbl.TabIndex = 2;
            this.fnlbl.Text = "First Name";
            // 
            // lnlbl
            // 
            this.lnlbl.AutoSize = true;
            this.lnlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lnlbl.Location = new System.Drawing.Point(42, 149);
            this.lnlbl.Name = "lnlbl";
            this.lnlbl.Size = new System.Drawing.Size(77, 17);
            this.lnlbl.TabIndex = 3;
            this.lnlbl.Text = "Last Name";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.emaillbl.Location = new System.Drawing.Point(42, 184);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(43, 17);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email";
            // 
            // phnumlbl
            // 
            this.phnumlbl.AutoSize = true;
            this.phnumlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnumlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.phnumlbl.Location = new System.Drawing.Point(42, 222);
            this.phnumlbl.Name = "phnumlbl";
            this.phnumlbl.Size = new System.Drawing.Size(80, 17);
            this.phnumlbl.TabIndex = 5;
            this.phnumlbl.Text = "Phone No.:";
            // 
            // stdnumtb
            // 
            this.stdnumtb.Location = new System.Drawing.Point(173, 67);
            this.stdnumtb.Name = "stdnumtb";
            this.stdnumtb.Size = new System.Drawing.Size(126, 20);
            this.stdnumtb.TabIndex = 6;
            // 
            // fntb
            // 
            this.fntb.Location = new System.Drawing.Point(173, 107);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(126, 20);
            this.fntb.TabIndex = 7;
            // 
            // lntb
            // 
            this.lntb.Location = new System.Drawing.Point(173, 142);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(126, 20);
            this.lntb.TabIndex = 8;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(173, 177);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(126, 20);
            this.emailtb.TabIndex = 9;
            // 
            // phnumtb
            // 
            this.phnumtb.Location = new System.Drawing.Point(173, 215);
            this.phnumtb.Name = "phnumtb";
            this.phnumtb.Size = new System.Drawing.Size(126, 20);
            this.phnumtb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(12, 320);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(30, 30);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "<--";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // stuportDatabaseDataSet
            // 
            this.stuportDatabaseDataSet.DataSetName = "StuportDatabaseDataSet";
            this.stuportDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuportDatabaseDataSetBindingSource
            // 
            this.stuportDatabaseDataSetBindingSource.DataSource = this.stuportDatabaseDataSet;
            this.stuportDatabaseDataSetBindingSource.Position = 0;
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.minimizelbl.Location = new System.Drawing.Point(292, 7);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(16, 17);
            this.minimizelbl.TabIndex = 14;
            this.minimizelbl.Text = "_";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.exitlbl.Location = new System.Drawing.Point(314, 7);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(17, 17);
            this.exitlbl.TabIndex = 13;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(173, 256);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(126, 23);
            this.btnChangePassword.TabIndex = 15;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(339, 362);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phnumtb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.lntb);
            this.Controls.Add(this.fntb);
            this.Controls.Add(this.stdnumtb);
            this.Controls.Add(this.phnumlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.lnlbl);
            this.Controls.Add(this.fnlbl);
            this.Controls.Add(this.stdnumlbl);
            this.Controls.Add(this.titlelbl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label stdnumlbl;
        private System.Windows.Forms.Label fnlbl;
        private System.Windows.Forms.Label lnlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label phnumlbl;
        private System.Windows.Forms.TextBox stdnumtb;
        private System.Windows.Forms.TextBox fntb;
        private System.Windows.Forms.TextBox lntb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox phnumtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.BindingSource stuportDatabaseDataSetBindingSource;
        private StuportDatabaseDataSet stuportDatabaseDataSet;
        private System.Windows.Forms.Label minimizelbl;
        private System.Windows.Forms.Label exitlbl;
        private System.Windows.Forms.Button btnChangePassword;
    }
}