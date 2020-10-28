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
            this.components = new System.ComponentModel.Container();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.bntCancelAppointment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnGroupSessions = new System.Windows.Forms.Button();
            this.stuportDatabaseDataSet3 = new Stuport.StuportDatabaseDataSet3();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Stuport.StuportDatabaseDataSet3TableAdapters.AppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(665, 316);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(123, 23);
            this.btnNewAppointment.TabIndex = 0;
            this.btnNewAppointment.Text = "New Appointment";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);
            // 
            // bntCancelAppointment
            // 
            this.bntCancelAppointment.Location = new System.Drawing.Point(523, 316);
            this.bntCancelAppointment.Name = "bntCancelAppointment";
            this.bntCancelAppointment.Size = new System.Drawing.Size(123, 23);
            this.bntCancelAppointment.TabIndex = 1;
            this.bntCancelAppointment.Text = "Cancel Appointment Appointment";
            this.bntCancelAppointment.UseVisualStyleBackColor = true;
            this.bntCancelAppointment.Click += new System.EventHandler(this.BntCancelAppointment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(191, 67);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(446, 210);
            this.dgvAppointment.TabIndex = 3;
            this.dgvAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAppointment_CellContentClick);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(327, 9);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(180, 31);
            this.lblAppointments.TabIndex = 4;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnGroupSessions
            // 
            this.btnGroupSessions.Location = new System.Drawing.Point(394, 316);
            this.btnGroupSessions.Name = "btnGroupSessions";
            this.btnGroupSessions.Size = new System.Drawing.Size(123, 23);
            this.btnGroupSessions.TabIndex = 5;
            this.btnGroupSessions.Text = "View Group Sessions";
            this.btnGroupSessions.UseVisualStyleBackColor = true;
            this.btnGroupSessions.Click += new System.EventHandler(this.btnGroupSessions_Click);
            // 
            // stuportDatabaseDataSet3
            // 
            this.stuportDatabaseDataSet3.DataSetName = "StuportDatabaseDataSet3";
            this.stuportDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.stuportDatabaseDataSet3;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // StudentAppointmentsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 352);
            this.Controls.Add(this.btnGroupSessions);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bntCancelAppointment);
            this.Controls.Add(this.btnNewAppointment);
            this.Name = "StudentAppointmentsHome";
            this.Text = "AppointmentsHome";
            this.Load += new System.EventHandler(this.StudentAppointmentsHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.Button bntCancelAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnGroupSessions;
        private StuportDatabaseDataSet3 stuportDatabaseDataSet3;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private StuportDatabaseDataSet3TableAdapters.AppointmentTableAdapter appointmentTableAdapter;
    }
}