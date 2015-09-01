namespace Deutsch_Englisch_Karteikarten
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.karteikartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wörterbuchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerEintragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karteikartenToolStripMenuItem,
            this.wörterbuchToolStripMenuItem,
            this.neuerEintragToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // karteikartenToolStripMenuItem
            // 
            this.karteikartenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem1,
            this.englischToolStripMenuItem1});
            this.karteikartenToolStripMenuItem.Name = "karteikartenToolStripMenuItem";
            this.karteikartenToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.karteikartenToolStripMenuItem.Text = "Karteikarten";
            // 
            // deutschToolStripMenuItem1
            // 
            this.deutschToolStripMenuItem1.Name = "deutschToolStripMenuItem1";
            this.deutschToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deutschToolStripMenuItem1.Text = "Englisch";
            this.deutschToolStripMenuItem1.Click += new System.EventHandler(this.deutschToolStripMenuItem1_Click);
            // 
            // englischToolStripMenuItem1
            // 
            this.englischToolStripMenuItem1.Name = "englischToolStripMenuItem1";
            this.englischToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.englischToolStripMenuItem1.Text = "Deutsch";
            this.englischToolStripMenuItem1.Click += new System.EventHandler(this.englischToolStripMenuItem1_Click);
            // 
            // wörterbuchToolStripMenuItem
            // 
            this.wörterbuchToolStripMenuItem.Name = "wörterbuchToolStripMenuItem";
            this.wörterbuchToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.wörterbuchToolStripMenuItem.Text = "Wörterbuch";
            this.wörterbuchToolStripMenuItem.Click += new System.EventHandler(this.wörterbuchToolStripMenuItem_Click);
            // 
            // neuerEintragToolStripMenuItem
            // 
            this.neuerEintragToolStripMenuItem.Name = "neuerEintragToolStripMenuItem";
            this.neuerEintragToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.neuerEintragToolStripMenuItem.Text = "Neuer Eintrag";
            this.neuerEintragToolStripMenuItem.Click += new System.EventHandler(this.neuerEintragToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Karteikarten";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karteikartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wörterbuchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerEintragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem1;
    }
}

