namespace Stuport.StudentMenu
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
            this.profilelbl = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stdNumtb = new System.Windows.Forms.TextBox();
            this.fntb = new System.Windows.Forms.TextBox();
            this.lntb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.phnumtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // profilelbl
            // 
            this.profilelbl.AutoSize = true;
            this.profilelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilelbl.Location = new System.Drawing.Point(132, 9);
            this.profilelbl.Name = "profilelbl";
            this.profilelbl.Size = new System.Drawing.Size(107, 24);
            this.profilelbl.TabIndex = 0;
            this.profilelbl.Text = "Your Profile";
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(254, 315);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(88, 23);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update Profile";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone No.:";
            // 
            // stdNumtb
            // 
            this.stdNumtb.Location = new System.Drawing.Point(182, 68);
            this.stdNumtb.Name = "stdNumtb";
            this.stdNumtb.Size = new System.Drawing.Size(100, 20);
            this.stdNumtb.TabIndex = 12;
            this.stdNumtb.TextChanged += new System.EventHandler(this.stdNumtb_TextChanged);
            // 
            // fntb
            // 
            this.fntb.Location = new System.Drawing.Point(182, 114);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(100, 20);
            this.fntb.TabIndex = 13;
            // 
            // lntb
            // 
            this.lntb.Location = new System.Drawing.Point(182, 160);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(100, 20);
            this.lntb.TabIndex = 14;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(182, 205);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(100, 20);
            this.emailtb.TabIndex = 15;
            // 
            // phnumtb
            // 
            this.phnumtb.Location = new System.Drawing.Point(182, 249);
            this.phnumtb.Name = "phnumtb";
            this.phnumtb.Size = new System.Drawing.Size(100, 20);
            this.phnumtb.TabIndex = 16;
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 350);
            this.Controls.Add(this.phnumtb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.lntb);
            this.Controls.Add(this.fntb);
            this.Controls.Add(this.stdNumtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.profilelbl);
            this.Name = "StudentProfile";
            this.Text = "StudentProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profilelbl;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stdNumtb;
        private System.Windows.Forms.TextBox fntb;
        private System.Windows.Forms.TextBox lntb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox phnumtb;
    }
}