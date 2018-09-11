namespace HelloWorldMenuNoahV
{
    partial class frmHelloWorldMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuProgram1 = new System.Windows.Forms.ToolStripMenuItem();
            this.youToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram2 = new System.Windows.Forms.ToolStripMenuItem();
            this.youToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgram1,
            this.mnuProgram2,
            this.youToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuProgram1
            // 
            this.mnuProgram1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youToolStripMenuItem});
            this.mnuProgram1.Name = "mnuProgram1";
            this.mnuProgram1.Size = new System.Drawing.Size(25, 20);
            this.mnuProgram1.Text = "1";
            // 
            // youToolStripMenuItem
            // 
            this.youToolStripMenuItem.Name = "youToolStripMenuItem";
            this.youToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.youToolStripMenuItem.Text = "you";
            // 
            // mnuProgram2
            // 
            this.mnuProgram2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuProgram2.Name = "mnuProgram2";
            this.mnuProgram2.Size = new System.Drawing.Size(25, 20);
            this.mnuProgram2.Text = "2";
            this.mnuProgram2.Click += new System.EventHandler(this.hepToolStripMenuItem_Click);
            // 
            // youToolStripMenuItem1
            // 
            this.youToolStripMenuItem1.Name = "youToolStripMenuItem1";
            this.youToolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.youToolStripMenuItem1.Text = "3";
            this.youToolStripMenuItem1.Click += new System.EventHandler(this.youToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "4";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem2.Text = "5";
            // 
            // frmHelloWorldMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 323);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHelloWorldMenu";
            this.Text = "Hello World Menu By NoahV";
            this.Load += new System.EventHandler(this.frmHelloWorldMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuProgram1;
        private System.Windows.Forms.ToolStripMenuItem mnuProgram2;
        private System.Windows.Forms.ToolStripMenuItem youToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

