namespace Stuport
{
    partial class StaffPage
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
            this.StaffLabel = new System.Windows.Forms.Label();
            this.StaffTableGridView = new System.Windows.Forms.DataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stuportDatabaseDataSet = new Stuport.StuportDatabaseDataSet();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelTableAdapter = new Stuport.StuportDatabaseDataSetTableAdapters.PersonnelTableAdapter();
            this.personnelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLabel.Location = new System.Drawing.Point(315, 61);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(175, 39);
            this.StaffLabel.TabIndex = 0;
            this.StaffLabel.Text = "Staff Page";
            this.StaffLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // StaffTableGridView
            // 
            this.StaffTableGridView.AutoGenerateColumns = false;
            this.StaffTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffTableGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelIDDataGridViewTextBoxColumn,
            this.personnelFirstNameDataGridViewTextBoxColumn,
            this.personnelLastNameDataGridViewTextBoxColumn,
            this.personnelEmailDataGridViewTextBoxColumn,
            this.personnelPhoneDataGridViewTextBoxColumn,
            this.personnelTypeDataGridViewTextBoxColumn});
            this.StaffTableGridView.DataSource = this.personnelBindingSource;
            this.StaffTableGridView.Location = new System.Drawing.Point(76, 114);
            this.StaffTableGridView.Name = "StaffTableGridView";
            this.StaffTableGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.StaffTableGridView.RowTemplate.DividerHeight = 1;
            this.StaffTableGridView.Size = new System.Drawing.Size(645, 148);
            this.StaffTableGridView.TabIndex = 1;
            this.StaffTableGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffTableGridView_CellContentClick);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(76, 315);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(85, 33);
            this.btnAddStaff.TabIndex = 2;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(167, 315);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(85, 33);
            this.btnUpdateDetails.TabIndex = 3;
            this.btnUpdateDetails.Text = "Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.BtnUpdateDetails_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Location = new System.Drawing.Point(636, 315);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(85, 32);
            this.btnRemoveStaff.TabIndex = 4;
            this.btnRemoveStaff.Text = "Remove";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exitToolStripMenuItem.Text = "Window";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // stuportDatabaseDataSet
            // 
            this.stuportDatabaseDataSet.DataSetName = "StuportDatabaseDataSet";
            this.stuportDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "Personnel";
            this.personnelBindingSource.DataSource = this.stuportDatabaseDataSet;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // personnelIDDataGridViewTextBoxColumn
            // 
            this.personnelIDDataGridViewTextBoxColumn.DataPropertyName = "Personnel_ID";
            this.personnelIDDataGridViewTextBoxColumn.HeaderText = "Personnel_ID";
            this.personnelIDDataGridViewTextBoxColumn.Name = "personnelIDDataGridViewTextBoxColumn";
            // 
            // personnelFirstNameDataGridViewTextBoxColumn
            // 
            this.personnelFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Personnel_FirstName";
            this.personnelFirstNameDataGridViewTextBoxColumn.HeaderText = "Personnel_FirstName";
            this.personnelFirstNameDataGridViewTextBoxColumn.Name = "personnelFirstNameDataGridViewTextBoxColumn";
            // 
            // personnelLastNameDataGridViewTextBoxColumn
            // 
            this.personnelLastNameDataGridViewTextBoxColumn.DataPropertyName = "Personnel_LastName";
            this.personnelLastNameDataGridViewTextBoxColumn.HeaderText = "Personnel_LastName";
            this.personnelLastNameDataGridViewTextBoxColumn.Name = "personnelLastNameDataGridViewTextBoxColumn";
            // 
            // personnelEmailDataGridViewTextBoxColumn
            // 
            this.personnelEmailDataGridViewTextBoxColumn.DataPropertyName = "Personnel_Email";
            this.personnelEmailDataGridViewTextBoxColumn.HeaderText = "Personnel_Email";
            this.personnelEmailDataGridViewTextBoxColumn.Name = "personnelEmailDataGridViewTextBoxColumn";
            // 
            // personnelPhoneDataGridViewTextBoxColumn
            // 
            this.personnelPhoneDataGridViewTextBoxColumn.DataPropertyName = "Personnel_Phone";
            this.personnelPhoneDataGridViewTextBoxColumn.HeaderText = "Personnel_Phone";
            this.personnelPhoneDataGridViewTextBoxColumn.Name = "personnelPhoneDataGridViewTextBoxColumn";
            // 
            // personnelTypeDataGridViewTextBoxColumn
            // 
            this.personnelTypeDataGridViewTextBoxColumn.DataPropertyName = "Personnel_Type";
            this.personnelTypeDataGridViewTextBoxColumn.HeaderText = "Personnel_Type";
            this.personnelTypeDataGridViewTextBoxColumn.Name = "personnelTypeDataGridViewTextBoxColumn";
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 383);
            this.Controls.Add(this.btnRemoveStaff);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.StaffTableGridView);
            this.Controls.Add(this.StaffLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StaffPage";
            this.Text = "Staff Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuportDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaffLabel;
        private System.Windows.Forms.DataGridView StaffTableGridView;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private StuportDatabaseDataSet stuportDatabaseDataSet;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private StuportDatabaseDataSetTableAdapters.PersonnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelTypeDataGridViewTextBoxColumn;
    }
}

