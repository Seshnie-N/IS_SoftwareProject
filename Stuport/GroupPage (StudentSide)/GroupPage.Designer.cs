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
            this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.Location = new System.Drawing.Point(145, 9);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(260, 25);
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
            this.dgvGroups.Location = new System.Drawing.Point(24, 47);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.Size = new System.Drawing.Size(503, 184);
            this.dgvGroups.TabIndex = 7;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(24, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnJoinGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinGroup.Location = new System.Drawing.Point(692, 208);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(76, 23);
            this.btnJoinGroup.TabIndex = 10;
            this.btnJoinGroup.Text = "Join Group";
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            // 
            // bntRequestGroup
            // 
            this.bntRequestGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRequestGroup.Location = new System.Drawing.Point(616, 428);
            this.bntRequestGroup.Name = "bntRequestGroup";
            this.bntRequestGroup.Size = new System.Drawing.Size(158, 23);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(635, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Active Groups";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(612, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
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
            this.dgvActiveGroups.Location = new System.Drawing.Point(560, 47);
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
            this.dgvRequestGroup.Location = new System.Drawing.Point(560, 272);
            this.dgvRequestGroup.Name = "dgvRequestGroup";
            this.dgvRequestGroup.ReadOnly = true;
            this.dgvRequestGroup.Size = new System.Drawing.Size(258, 150);
            this.dgvRequestGroup.TabIndex = 15;
            this.dgvRequestGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestGroup_CellContentClick);
            // 
            // btnGroupDetails
            // 
            this.btnGroupDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnGroupDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupDetails.Location = new System.Drawing.Point(610, 208);
            this.btnGroupDetails.Name = "btnGroupDetails";
            this.btnGroupDetails.Size = new System.Drawing.Size(76, 23);
            this.btnGroupDetails.TabIndex = 16;
            this.btnGroupDetails.Text = "Details";
            this.btnGroupDetails.UseVisualStyleBackColor = true;
            this.btnGroupDetails.Click += new System.EventHandler(this.BtnGroupDetails_Click);
            // 
            // GroupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
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
    }
}