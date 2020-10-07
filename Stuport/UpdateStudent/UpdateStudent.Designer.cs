namespace Stuport
{
    partial class UpdateStudent
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdateStudenr = new System.Windows.Forms.Button();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvStudentUpdate = new System.Windows.Forms.DataGridView();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.stuportDatabaseDataSet = new Stuport.StuportDatabaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Stuport.StuportDatabaseDataSetTableAdapters.StudentTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 474);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateStudenr
            // 
            this.btnUpdateStudenr.Location = new System.Drawing.Point(620, 474);
            this.btnUpdateStudenr.Name = "btnUpdateStudenr";
            this.btnUpdateStudenr.Size = new System.Drawing.Size(156, 23);
            this.btnUpdateStudenr.TabIndex = 2;
            this.btnUpdateStudenr.Text = "Update Student Record";
            this.btnUpdateStudenr.UseVisualStyleBackColor = true;
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Location = new System.Drawing.Point(364, 280);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(53, 13);
            this.lblPassword1.TabIndex = 20;
            this.lblPassword1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(367, 296);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 19;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(364, 378);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNo.TabIndex = 18;
            this.lblPhoneNo.Text = "Contact Number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(367, 394);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNo.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(364, 328);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email Address";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(33, 394);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(204, 20);
            this.txtLName.TabIndex = 15;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(30, 378);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 14;
            this.lblLName.Text = "Last Name ";
            this.lblLName.Click += new System.EventHandler(this.lblLName_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(367, 344);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(30, 328);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 12;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(33, 344);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(204, 20);
            this.txtFName.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Find Student Record";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(148, 15);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(204, 20);
            this.txtStudentNo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter Student Number";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(620, 445);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(156, 23);
            this.btnAddStudent.TabIndex = 24;
            this.btnAddStudent.Text = "Add Student Record";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvStudentUpdate
            // 
            this.dgvStudentUpdate.AutoGenerateColumns = false;
            this.dgvStudentUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentFirstNameDataGridViewTextBoxColumn,
            this.studentLastNameDataGridViewTextBoxColumn,
            this.studentEmailDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentPasswordDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn});
            this.dgvStudentUpdate.DataSource = this.studentBindingSource;
            this.dgvStudentUpdate.Location = new System.Drawing.Point(33, 55);
            this.dgvStudentUpdate.Name = "dgvStudentUpdate";
            this.dgvStudentUpdate.Size = new System.Drawing.Size(753, 209);
            this.dgvStudentUpdate.TabIndex = 25;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(30, 280);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 27;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(33, 296);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(204, 20);
            this.txtStudentNumber.TabIndex = 26;
            // 
            // stuportDatabaseDataSet
            // 
            this.stuportDatabaseDataSet.DataSetName = "StuportDatabaseDataSet";
            this.stuportDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.stuportDatabaseDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentFirstNameDataGridViewTextBoxColumn
            // 
            this.studentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Student_FirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.HeaderText = "Student_FirstName";
            this.studentFirstNameDataGridViewTextBoxColumn.Name = "studentFirstNameDataGridViewTextBoxColumn";
            // 
            // studentLastNameDataGridViewTextBoxColumn
            // 
            this.studentLastNameDataGridViewTextBoxColumn.DataPropertyName = "Student_LastName";
            this.studentLastNameDataGridViewTextBoxColumn.HeaderText = "Student_LastName";
            this.studentLastNameDataGridViewTextBoxColumn.Name = "studentLastNameDataGridViewTextBoxColumn";
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "Student_Email";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "Student_Email";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "Student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "Student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            // 
            // studentPasswordDataGridViewTextBoxColumn
            // 
            this.studentPasswordDataGridViewTextBoxColumn.DataPropertyName = "Student_Password";
            this.studentPasswordDataGridViewTextBoxColumn.HeaderText = "Student_Password";
            this.studentPasswordDataGridViewTextBoxColumn.Name = "studentPasswordDataGridViewTextBoxColumn";
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 517);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.dgvStudentUpdate);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnUpdateStudenr);
            this.Controls.Add(this.btnBack);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateStudenr;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dgvStudentUpdate;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private Stuport.StuportDatabaseDataSet stuportDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Stuport.StuportDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
    }
}