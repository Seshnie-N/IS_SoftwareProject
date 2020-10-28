namespace Stuport.Groups_Service
{
    partial class Groups
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
            this.lblGroups = new System.Windows.Forms.Label();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.minimizelbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.lblGroups.Location = new System.Drawing.Point(336, 20);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(144, 33);
            this.lblGroups.TabIndex = 7;
            this.lblGroups.Text = "G r o u p s";
            // 
            // dgvGroups
            // 
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(16, 66);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(776, 212);
            this.dgvGroups.TabIndex = 8;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroups_CellContentClick);
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::Stuport.Properties.Resources.backArrow;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 451);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(719, 451);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(619, 451);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(448, 339);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 17);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(117, 312);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(225, 21);
            this.cmbService.TabIndex = 15;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.White;
            this.lblService.Location = new System.Drawing.Point(114, 295);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(53, 17);
            this.lblService.TabIndex = 14;
            this.lblService.Text = "Service";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.Color.White;
            this.lblVenue.Location = new System.Drawing.Point(114, 339);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(49, 17);
            this.lblVenue.TabIndex = 20;
            this.lblVenue.Text = "Venue";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(451, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(115, 401);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(227, 21);
            this.cmbStaff.TabIndex = 23;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.White;
            this.lblStaff.Location = new System.Drawing.Point(114, 384);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(36, 17);
            this.lblStaff.TabIndex = 22;
            this.lblStaff.Text = "Staff";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(115, 356);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(227, 20);
            this.txtVenue.TabIndex = 26;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(451, 309);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(227, 20);
            this.dtpTime.TabIndex = 27;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(451, 292);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 17);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(451, 356);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(227, 20);
            this.dtpDate.TabIndex = 29;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(451, 402);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(227, 20);
            this.txtStatus.TabIndex = 30;
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.BackColor = System.Drawing.Color.Transparent;
            this.minimizelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.minimizelbl.Location = new System.Drawing.Point(753, 4);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(17, 19);
            this.minimizelbl.TabIndex = 32;
            this.minimizelbl.Text = "_";
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.exitlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.exitlbl.Location = new System.Drawing.Point(779, 6);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(20, 19);
            this.exitlbl.TabIndex = 31;
            this.exitlbl.Text = "X";
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(3)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(806, 488);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.lblGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Groups";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label minimizelbl;
        private System.Windows.Forms.Label exitlbl;
    }
}