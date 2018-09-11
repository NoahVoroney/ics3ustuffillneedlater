namespace AddressProgramNoahV
{
    partial class frmAddressProgram
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.labeCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 73);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NoahV";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCity.Location = new System.Drawing.Point(0, 93);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(242, 73);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Ottawa";
            this.lblCity.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labeCountry
            // 
            this.labeCountry.AutoSize = true;
            this.labeCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeCountry.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labeCountry.Location = new System.Drawing.Point(0, 188);
            this.labeCountry.Name = "labeCountry";
            this.labeCountry.Size = new System.Drawing.Size(264, 73);
            this.labeCountry.TabIndex = 2;
            this.labeCountry.Text = "Canada";
            // 
            // frmAddressProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.labeCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAddressProgram";
            this.Text = "Adress Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label labeCountry;
    }
}

