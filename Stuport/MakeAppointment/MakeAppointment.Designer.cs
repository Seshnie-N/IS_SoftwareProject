﻿namespace Stuport
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
            this.label1 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxServiceType = new System.Windows.Forms.ComboBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTimeSlot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Type of Service";
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(47, 97);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date";
            // 
            // cbxServiceType
            // 
            this.cbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServiceType.FormattingEnabled = true;
            this.cbxServiceType.Items.AddRange(new object[] {
            "Personal psychological services",
            "Personal academic help"});
            this.cbxServiceType.Location = new System.Drawing.Point(47, 36);
            this.cbxServiceType.Name = "cbxServiceType";
            this.cbxServiceType.Size = new System.Drawing.Size(227, 21);
            this.cbxServiceType.TabIndex = 4;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(47, 322);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(127, 38);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "Request Appointment";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Preferred Time Slot";
            // 
            // cbxTimeSlot
            // 
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
            this.cbxTimeSlot.Location = new System.Drawing.Point(180, 291);
            this.cbxTimeSlot.Name = "cbxTimeSlot";
            this.cbxTimeSlot.Size = new System.Drawing.Size(94, 21);
            this.cbxTimeSlot.TabIndex = 9;
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 402);
            this.Controls.Add(this.cbxTimeSlot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.cbxServiceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.label1);
            this.Name = "MakeAppointment";
            this.Text = "MakeAppointment";
            this.Load += new System.EventHandler(this.MakeAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxServiceType;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTimeSlot;
    }
}