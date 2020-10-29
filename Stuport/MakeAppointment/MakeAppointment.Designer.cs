namespace Stuport
{
    partial class MakeAppointment
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
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxServiceType = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuportDatabaseDataSet2 = new Stuport.StuportDatabaseDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTimeSlot = new System.Windows.Forms.ComboBox();
            this.serviceTableAdapter = new Stuport.StuportDatabaseDataSet2TableAdapters.ServiceTableAdapter();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.minimizelbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Type of Service";
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(78, 145);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date";
            // 
            // cbxServiceType
            // 
            this.cbxServiceType.BackColor = System.Drawing.Color.White;
            this.cbxServiceType.DataSource = this.serviceBindingSource;
            this.cbxServiceType.DisplayMember = "Service_Description";
            this.cbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServiceType.FormattingEnabled = true;
            this.cbxServiceType.Location = new System.Drawing.Point(78, 82);
            this.cbxServiceType.Name = "cbxServiceType";
            this.cbxServiceType.Size = new System.Drawing.Size(227, 21);
            this.cbxServiceType.TabIndex = 4;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.stuportDatabaseDataSet2;
            // 
            // stuportDatabaseDataSet2
            // 
            this.stuportDatabaseDataSet2.DataSetName = "StuportDatabaseDataSet2";
            this.stuportDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(44, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Preferred Time Slot";
            // 
            // cbxTimeSlot
            // 
            this.cbxTimeSlot.BackColor = System.Drawing.Color.White;
            this.cbxTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeSlot.FormattingEnabled = true;
            this.cbxTimeSlot.Items.AddRange(new object[] {
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "12:00-13:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00"});
            this.cbxTimeSlot.Location = new System.Drawing.Point(211, 330);
            this.cbxTimeSlot.Name = "cbxTimeSlot";
            this.cbxTimeSlot.Size = new System.Drawing.Size(94, 21);
            this.cbxTimeSlot.TabIndex = 9;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnRequest.Location = new System.Drawing.Point(116, 382);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(137, 26);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "Request Appointment";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(78, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Make Appointment";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.backbtn.Location = new System.Drawing.Point(4, 386);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(30, 30);
            this.backbtn.TabIndex = 11;
            this.backbtn.Text = "<--";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.minimizelbl.Location = new System.Drawing.Point(323, 6);
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
            this.exitlbl.Location = new System.Drawing.Point(345, 6);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(17, 17);
            this.exitlbl.TabIndex = 13;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(368, 420);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTimeSlot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.cbxServiceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Appointment";
            this.Load += new System.EventHandler(this.MakeAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxServiceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTimeSlot;
        private StuportDatabaseDataSet2 stuportDatabaseDataSet2;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private StuportDatabaseDataSet2TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label minimizelbl;
        private System.Windows.Forms.Label exitlbl;
    }
}