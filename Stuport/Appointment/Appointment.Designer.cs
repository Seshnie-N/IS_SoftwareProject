namespace stuport_section
{
    partial class Appointment
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
            this.appointHLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.approvebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appointHLbl
            // 
            this.appointHLbl.AutoSize = true;
            this.appointHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointHLbl.Location = new System.Drawing.Point(338, 33);
            this.appointHLbl.Name = "appointHLbl";
            this.appointHLbl.Size = new System.Drawing.Size(126, 24);
            this.appointHLbl.TabIndex = 0;
            this.appointHLbl.Text = "Appointments";
            this.appointHLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 222);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // approvebtn
            // 
            this.approvebtn.Location = new System.Drawing.Point(661, 415);
            this.approvebtn.Name = "approvebtn";
            this.approvebtn.Size = new System.Drawing.Size(122, 23);
            this.approvebtn.TabIndex = 3;
            this.approvebtn.Text = "Approve Appointment";
            this.approvebtn.UseVisualStyleBackColor = true;
            this.approvebtn.Click += new System.EventHandler(this.approvebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(518, 415);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(113, 23);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "Cancel Appointment";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.approvebtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.appointHLbl);
            this.Name = "Appointment";
            this.Text = "Appointment(Admin)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointHLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button approvebtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}

