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
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.titlelbl.Location = new System.Drawing.Point(99, 21);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(137, 33);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "P r o f i l e";
            // 
            // stdnumlbl
            // 
            this.stdnumlbl.AutoSize = true;
            this.stdnumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdnumlbl.ForeColor = System.Drawing.Color.White;
            this.stdnumlbl.Location = new System.Drawing.Point(42, 79);
            this.stdnumlbl.Name = "stdnumlbl";
            this.stdnumlbl.Size = new System.Drawing.Size(80, 16);
            this.stdnumlbl.TabIndex = 1;
            this.stdnumlbl.Text = "Student No.:";
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlbl.ForeColor = System.Drawing.Color.White;
            this.fnlbl.Location = new System.Drawing.Point(42, 118);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(73, 16);
            this.fnlbl.TabIndex = 2;
            this.fnlbl.Text = "First Name";
            // 
            // lnlbl
            // 
            this.lnlbl.AutoSize = true;
            this.lnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlbl.ForeColor = System.Drawing.Color.White;
            this.lnlbl.Location = new System.Drawing.Point(42, 153);
            this.lnlbl.Name = "lnlbl";
            this.lnlbl.Size = new System.Drawing.Size(73, 16);
            this.lnlbl.TabIndex = 3;
            this.lnlbl.Text = "Last Name";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.Color.White;
            this.emaillbl.Location = new System.Drawing.Point(42, 188);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(42, 16);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email";
            // 
            // phnumlbl
            // 
            this.phnumlbl.AutoSize = true;
            this.phnumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnumlbl.ForeColor = System.Drawing.Color.White;
            this.phnumlbl.Location = new System.Drawing.Point(42, 226);
            this.phnumlbl.Name = "phnumlbl";
            this.phnumlbl.Size = new System.Drawing.Size(74, 16);
            this.phnumlbl.TabIndex = 5;
            this.phnumlbl.Text = "Phone No.:";
            // 
            // stdnumtb
            // 
            this.stdnumtb.Location = new System.Drawing.Point(178, 78);
            this.stdnumtb.Name = "stdnumtb";
            this.stdnumtb.Size = new System.Drawing.Size(118, 20);
            this.stdnumtb.TabIndex = 6;
            // 
            // fntb
            // 
            this.fntb.Location = new System.Drawing.Point(178, 118);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(118, 20);
            this.fntb.TabIndex = 7;
            // 
            // lntb
            // 
            this.lntb.Location = new System.Drawing.Point(178, 153);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(118, 20);
            this.lntb.TabIndex = 8;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(178, 188);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(118, 20);
            this.emailtb.TabIndex = 9;
            // 
            // phnumtb
            // 
            this.phnumtb.Location = new System.Drawing.Point(178, 226);
            this.phnumtb.Name = "phnumtb";
            this.phnumtb.Size = new System.Drawing.Size(118, 20);
            this.phnumtb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.White;
            this.backbtn.BackgroundImage = global::Stuport.Properties.Resources.backArrow;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 312);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(30, 30);
            this.backbtn.TabIndex = 12;
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
            this.minimizelbl.BackColor = System.Drawing.Color.Transparent;
            this.minimizelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.minimizelbl.Location = new System.Drawing.Point(283, 6);
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
            this.exitlbl.Location = new System.Drawing.Point(309, 8);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(20, 19);
            this.exitlbl.TabIndex = 16;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(3)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(335, 349);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentProfile";
            this.Text = "StudentProfile";
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
    }
}