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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuportDatabaseDataSet = new Stuport.StuportDatabaseDataSet();
            this.stuportDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(131, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(62, 24);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Profile";
            // 
            // stdnumlbl
            // 
            this.stdnumlbl.AutoSize = true;
            this.stdnumlbl.Location = new System.Drawing.Point(42, 75);
            this.stdnumlbl.Name = "stdnumlbl";
            this.stdnumlbl.Size = new System.Drawing.Size(69, 13);
            this.stdnumlbl.TabIndex = 1;
            this.stdnumlbl.Text = "Student No.:";
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Location = new System.Drawing.Point(42, 114);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(58, 13);
            this.fnlbl.TabIndex = 2;
            this.fnlbl.Text = "First Name";
            // 
            // lnlbl
            // 
            this.lnlbl.AutoSize = true;
            this.lnlbl.Location = new System.Drawing.Point(42, 149);
            this.lnlbl.Name = "lnlbl";
            this.lnlbl.Size = new System.Drawing.Size(57, 13);
            this.lnlbl.TabIndex = 3;
            this.lnlbl.Text = "Last Name";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(42, 184);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(31, 13);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email";
            // 
            // phnumlbl
            // 
            this.phnumlbl.AutoSize = true;
            this.phnumlbl.Location = new System.Drawing.Point(42, 222);
            this.phnumlbl.Name = "phnumlbl";
            this.phnumlbl.Size = new System.Drawing.Size(61, 13);
            this.phnumlbl.TabIndex = 5;
            this.phnumlbl.Text = "Phone No.:";
            // 
            // stdnumtb
            // 
            this.stdnumtb.Location = new System.Drawing.Point(173, 67);
            this.stdnumtb.Name = "stdnumtb";
            this.stdnumtb.Size = new System.Drawing.Size(100, 21);
            this.stdnumtb.TabIndex = 6;
            // 
            // fntb
            // 
            this.fntb.Location = new System.Drawing.Point(173, 107);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(100, 21);
            this.fntb.TabIndex = 7;
            // 
            // lntb
            // 
            this.lntb.Location = new System.Drawing.Point(173, 142);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(100, 21);
            this.lntb.TabIndex = 8;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(173, 177);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(100, 21);
            this.emailtb.TabIndex = 9;
            // 
            // phnumtb
            // 
            this.phnumtb.Location = new System.Drawing.Point(173, 215);
            this.phnumtb.Name = "phnumtb";
            this.phnumtb.Size = new System.Drawing.Size(100, 21);
            this.phnumtb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(580, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(45, 314);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(95, 23);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 150);
            this.dataGridView1.TabIndex = 13;
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
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 349);
            this.Controls.Add(this.dataGridView1);
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
            this.IconOptions.Image = global::Stuport.Properties.Resources.IMG_20201027_190658_804_removebg_preview;
            this.Name = "StudentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stuportDatabaseDataSetBindingSource;
        private StuportDatabaseDataSet stuportDatabaseDataSet;
    }
}