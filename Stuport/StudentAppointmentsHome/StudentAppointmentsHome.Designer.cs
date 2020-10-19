namespace Stuport
{
    partial class StudentAppointmentsHome
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
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.bntCancelAppointment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnGroupSessions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(665, 452);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(123, 23);
            this.btnNewAppointment.TabIndex = 0;
            this.btnNewAppointment.Text = "New Appointment";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);
            // 
            // bntCancelAppointment
            // 
            this.bntCancelAppointment.Location = new System.Drawing.Point(523, 452);
            this.bntCancelAppointment.Name = "bntCancelAppointment";
            this.bntCancelAppointment.Size = new System.Drawing.Size(123, 23);
            this.bntCancelAppointment.TabIndex = 1;
            this.bntCancelAppointment.Text = "Cancel Appointment Appointment";
            this.bntCancelAppointment.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 358);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(300, 9);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(180, 31);
            this.lblAppointments.TabIndex = 4;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnGroupSessions
            // 
            this.btnGroupSessions.Location = new System.Drawing.Point(394, 452);
            this.btnGroupSessions.Name = "btnGroupSessions";
            this.btnGroupSessions.Size = new System.Drawing.Size(123, 23);
            this.btnGroupSessions.TabIndex = 5;
            this.btnGroupSessions.Text = "View Group Sessions";
            this.btnGroupSessions.UseVisualStyleBackColor = true;
            // 
            // StudentAppointmentsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btnGroupSessions);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bntCancelAppointment);
            this.Controls.Add(this.btnNewAppointment);
            this.Name = "StudentAppointmentsHome";
            this.Text = "AppointmentsHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.Button bntCancelAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnGroupSessions;
    }
}