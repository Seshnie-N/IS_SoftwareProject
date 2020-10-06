namespace stuport_section
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
            this.button3 = new System.Windows.Forms.Button();
            this.service3btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msHLbl
            // 
            this.msHLbl.AutoSize = true;
            this.msHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msHLbl.Location = new System.Drawing.Point(216, 38);
            this.msHLbl.Name = "msHLbl";
            this.msHLbl.Size = new System.Drawing.Size(131, 24);
            this.msHLbl.TabIndex = 0;
            this.msHLbl.Text = "More Services";
            this.msHLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // financialbtn
            // 
            this.financialbtn.Location = new System.Drawing.Point(131, 112);
            this.financialbtn.Name = "financialbtn";
            this.financialbtn.Size = new System.Drawing.Size(116, 33);
            this.financialbtn.TabIndex = 1;
            this.financialbtn.Text = "Financial Aid";
            this.financialbtn.UseVisualStyleBackColor = true;
            this.financialbtn.Click += new System.EventHandler(this.financialbtn_Click);
            // 
            // residencebtn
            // 
            this.residencebtn.Location = new System.Drawing.Point(302, 112);
            this.residencebtn.Name = "residencebtn";
            this.residencebtn.Size = new System.Drawing.Size(116, 33);
            this.residencebtn.TabIndex = 2;
            this.residencebtn.Text = "Residence";
            this.residencebtn.UseVisualStyleBackColor = true;
            this.residencebtn.Click += new System.EventHandler(this.residencebtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "service4";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // service3btn
            // 
            this.service3btn.Location = new System.Drawing.Point(131, 192);
            this.service3btn.Name = "service3btn";
            this.service3btn.Size = new System.Drawing.Size(116, 33);
            this.service3btn.TabIndex = 4;
            this.service3btn.Text = "service3";
            this.service3btn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Other_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 327);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.service3btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.residencebtn);
            this.Controls.Add(this.financialbtn);
            this.Controls.Add(this.msHLbl);
            this.Name = "Other_Services";
            this.Text = "Other_Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msHLbl;
        private System.Windows.Forms.Button financialbtn;
        private System.Windows.Forms.Button residencebtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button service3btn;
        private System.Windows.Forms.Button button5;
    }
}