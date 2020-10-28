namespace Stuport
{
    partial class GroupPage
    {

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
            this.btnJoinGroup = new System.Windows.Forms.Button();
            this.bntRequestGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvActiveGroups = new System.Windows.Forms.DataGridView();
            this.dgvRequestGroup = new System.Windows.Forms.DataGridView();
            this.btnGroupDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.leaveGroupbtn = new System.Windows.Forms.Button();
            this.minimizelbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroups
            // 
            this.lblGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroups.AutoSize = true;
            this.lblGroups.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.lblGroups.Location = new System.Drawing.Point(270, 18);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(323, 30);
            this.lblGroups.TabIndex = 6;
            this.lblGroups.Text = "Your Group Appointments";
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGroups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(25, 148);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.Size = new System.Drawing.Size(503, 184);
            this.dgvGroups.TabIndex = 7;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(9, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnJoinGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnJoinGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinGroup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGroup.Location = new System.Drawing.Point(742, 226);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(76, 23);
            this.btnJoinGroup.TabIndex = 10;
            this.btnJoinGroup.Text = "Join Group";
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            // 
            // bntRequestGroup
            // 
            this.bntRequestGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.bntRequestGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRequestGroup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRequestGroup.Location = new System.Drawing.Point(636, 436);
            this.bntRequestGroup.Name = "bntRequestGroup";
            this.bntRequestGroup.Size = new System.Drawing.Size(182, 24);
            this.bntRequestGroup.TabIndex = 11;
            this.bntRequestGroup.Text = "Request Group Appointment";
            this.bntRequestGroup.UseVisualStyleBackColor = true;
            this.bntRequestGroup.Click += new System.EventHandler(this.bntRequestGroup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(635, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Active Groups";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(618, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Request for a Group";
            // 
            // dgvActiveGroups
            // 
            this.dgvActiveGroups.AllowUserToAddRows = false;
            this.dgvActiveGroups.AllowUserToDeleteRows = false;
            this.dgvActiveGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActiveGroups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.dgvActiveGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveGroups.Location = new System.Drawing.Point(560, 70);
            this.dgvActiveGroups.Name = "dgvActiveGroups";
            this.dgvActiveGroups.ReadOnly = true;
            this.dgvActiveGroups.Size = new System.Drawing.Size(258, 150);
            this.dgvActiveGroups.TabIndex = 14;
            this.dgvActiveGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveGroups_CellContentClick);
            // 
            // dgvRequestGroup
            // 
            this.dgvRequestGroup.AllowUserToAddRows = false;
            this.dgvRequestGroup.AllowUserToDeleteRows = false;
            this.dgvRequestGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRequestGroup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.dgvRequestGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestGroup.Location = new System.Drawing.Point(560, 296);
            this.dgvRequestGroup.Name = "dgvRequestGroup";
            this.dgvRequestGroup.ReadOnly = true;
            this.dgvRequestGroup.Size = new System.Drawing.Size(258, 125);
            this.dgvRequestGroup.TabIndex = 15;
            this.dgvRequestGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestGroup_CellContentClick);
            // 
            // btnGroupDetails
            // 
            this.btnGroupDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnGroupDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnGroupDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupDetails.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupDetails.Location = new System.Drawing.Point(660, 226);
            this.btnGroupDetails.Name = "btnGroupDetails";
            this.btnGroupDetails.Size = new System.Drawing.Size(76, 23);
            this.btnGroupDetails.TabIndex = 16;
            this.btnGroupDetails.Text = "Details";
            this.btnGroupDetails.UseVisualStyleBackColor = true;
            this.btnGroupDetails.Click += new System.EventHandler(this.BtnGroupDetails_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(245, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Joined";
            // 
            // leaveGroupbtn
            // 
            this.leaveGroupbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.leaveGroupbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.leaveGroupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveGroupbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveGroupbtn.Location = new System.Drawing.Point(452, 338);
            this.leaveGroupbtn.Name = "leaveGroupbtn";
            this.leaveGroupbtn.Size = new System.Drawing.Size(76, 23);
            this.leaveGroupbtn.TabIndex = 18;
            this.leaveGroupbtn.Text = "Leave Group";
            this.leaveGroupbtn.UseVisualStyleBackColor = true;
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minimizelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.minimizelbl.Location = new System.Drawing.Point(791, 9);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(16, 17);
            this.minimizelbl.TabIndex = 20;
            this.minimizelbl.Text = "_";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.exitlbl.Location = new System.Drawing.Point(813, 9);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(17, 17);
            this.exitlbl.TabIndex = 19;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // GroupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(842, 480);
            this.Controls.Add(this.minimizelbl);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.leaveGroupbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGroupDetails);
            this.Controls.Add(this.dgvRequestGroup);
            this.Controls.Add(this.dgvActiveGroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntRequestGroup);
            this.Controls.Add(this.btnJoinGroup);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.lblGroups);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupPage";
            this.Load += new System.EventHandler(this.GroupPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnJoinGroup;
        private System.Windows.Forms.Button bntRequestGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvActiveGroups;
        private System.Windows.Forms.DataGridView dgvRequestGroup;
        private System.Windows.Forms.Button btnGroupDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button leaveGroupbtn;
        private System.Windows.Forms.Label minimizelbl;
        private System.Windows.Forms.Label exitlbl;
    }
}