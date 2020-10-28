namespace Stuport
{
    partial class Other_Services
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
            this.msHLbl = new System.Windows.Forms.Label();
            this.financialbtn = new System.Windows.Forms.Button();
            this.residencebtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msHLbl
            // 
            this.msHLbl.AutoSize = true;
            this.msHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msHLbl.Location = new System.Drawing.Point(100, 43);
            this.msHLbl.Name = "msHLbl";
            this.msHLbl.Size = new System.Drawing.Size(131, 24);
            this.msHLbl.TabIndex = 0;
            this.msHLbl.Text = "More Services";
            this.msHLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // financialbtn
            // 
            this.financialbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financialbtn.Location = new System.Drawing.Point(104, 108);
            this.financialbtn.Name = "financialbtn";
            this.financialbtn.Size = new System.Drawing.Size(116, 33);
            this.financialbtn.TabIndex = 1;
            this.financialbtn.Text = "Financial Aid";
            this.financialbtn.UseVisualStyleBackColor = true;
            this.financialbtn.Click += new System.EventHandler(this.financialbtn_Click);
            // 
            // residencebtn
            // 
            this.residencebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.residencebtn.Location = new System.Drawing.Point(104, 156);
            this.residencebtn.Name = "residencebtn";
            this.residencebtn.Size = new System.Drawing.Size(116, 33);
            this.residencebtn.TabIndex = 2;
            this.residencebtn.Text = "Residence";
            this.residencebtn.UseVisualStyleBackColor = true;
            this.residencebtn.Click += new System.EventHandler(this.residencebtn_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(12, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Other_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 285);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.residencebtn);
            this.Controls.Add(this.financialbtn);
            this.Controls.Add(this.msHLbl);
            this.IconOptions.Image = global::Stuport.Properties.Resources.IMG_20201027_190658_804_removebg_preview;
            this.Name = "Other_Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Services";
            this.Load += new System.EventHandler(this.Other_Services_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msHLbl;
        private System.Windows.Forms.Button financialbtn;
        private System.Windows.Forms.Button residencebtn;
        private System.Windows.Forms.Button button5;
    }
}