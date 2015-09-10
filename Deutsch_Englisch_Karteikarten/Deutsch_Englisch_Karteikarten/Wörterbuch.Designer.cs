namespace Deutsch_Englisch_Karteikarten
{
    partial class Wörterbuch
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordDisplayBx = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // wordDisplayBx
            // 
            this.wordDisplayBx.BackColor = System.Drawing.SystemColors.Control;
            this.wordDisplayBx.FormattingEnabled = true;
            this.wordDisplayBx.Location = new System.Drawing.Point(195, 63);
            this.wordDisplayBx.Name = "wordDisplayBx";
            this.wordDisplayBx.Size = new System.Drawing.Size(157, 108);
            this.wordDisplayBx.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(105, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Deutsch -> Englisch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 63);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // Wörterbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordDisplayBx);
            this.Name = "Wörterbuch";
            this.Size = new System.Drawing.Size(400, 225);
            this.Load += new System.EventHandler(this.Wörterbuch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox wordDisplayBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;


    }
}
