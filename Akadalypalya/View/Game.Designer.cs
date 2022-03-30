namespace Akadalypalya
{
    partial class Akadalypalya
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
            this.strip = new System.Windows.Forms.ToolStrip();
            this.eletLabel = new System.Windows.Forms.ToolStripLabel();
            this.timerLabel = new System.Windows.Forms.ToolStripLabel();
            this.pointLabel = new System.Windows.Forms.ToolStripLabel();
            this.newGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenu,
            this.pauseMenu,
            this.continueMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // strip
            // 
            this.strip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eletLabel,
            this.timerLabel,
            this.pointLabel});
            this.strip.Location = new System.Drawing.Point(0, 436);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(584, 25);
            this.strip.TabIndex = 1;
            this.strip.Text = "toolStrip1";
            // 
            // eletLabel
            // 
            this.eletLabel.Name = "eletLabel";
            this.eletLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // timerLabel
            // 
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // pointLabel
            // 
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // newGameMenu
            // 
            this.newGameMenu.Name = "newGameMenu";
            this.newGameMenu.Size = new System.Drawing.Size(58, 20);
            this.newGameMenu.Text = "Új játék";
            this.newGameMenu.Click += new System.EventHandler(this.newGameMenu_Click);
            // 
            // pauseMenu
            // 
            this.pauseMenu.Name = "pauseMenu";
            this.pauseMenu.Size = new System.Drawing.Size(54, 20);
            this.pauseMenu.Text = "Szünet";
            this.pauseMenu.Click += new System.EventHandler(this.pauseMenu_Click);
            // 
            // continueMenu
            // 
            this.continueMenu.Name = "continueMenu";
            this.continueMenu.Size = new System.Drawing.Size(66, 20);
            this.continueMenu.Text = "Folytatás";
            this.continueMenu.Click += new System.EventHandler(this.continueMenu_Click);
            // 
            // Akadalypalya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Akadalypalya";
            this.Text = "Akadalypalya";
            this.Load += new System.EventHandler(this.Akadalypalya_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip strip;
        private System.Windows.Forms.ToolStripLabel eletLabel;
        private System.Windows.Forms.ToolStripLabel timerLabel;
        private System.Windows.Forms.ToolStripLabel pointLabel;
        private System.Windows.Forms.ToolStripMenuItem newGameMenu;
        private System.Windows.Forms.ToolStripMenuItem pauseMenu;
        private System.Windows.Forms.ToolStripMenuItem continueMenu;
    }
}

