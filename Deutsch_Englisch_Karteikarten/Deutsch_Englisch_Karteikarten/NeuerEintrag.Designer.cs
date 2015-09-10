namespace Deutsch_Englisch_Karteikarten
{
    partial class NeuerEintrag
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
            this._alterDatabaseBtn = new System.Windows.Forms.Button();
            this._lblDeutsch = new System.Windows.Forms.Label();
            this._lblEnglisch = new System.Windows.Forms.Label();
            this.DeutschComboBx = new System.Windows.Forms.ComboBox();
            this.EnglischComboBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _alterDatabaseBtn
            // 
            this._alterDatabaseBtn.Location = new System.Drawing.Point(304, 45);
            this._alterDatabaseBtn.Name = "_alterDatabaseBtn";
            this._alterDatabaseBtn.Size = new System.Drawing.Size(20, 20);
            this._alterDatabaseBtn.TabIndex = 3;
            this._alterDatabaseBtn.Text = "+";
            this._alterDatabaseBtn.UseVisualStyleBackColor = true;
            this._alterDatabaseBtn.Click += new System.EventHandler(this._alterDatabaseBtn_Click);
            // 
            // _lblDeutsch
            // 
            this._lblDeutsch.AutoSize = true;
            this._lblDeutsch.Location = new System.Drawing.Point(67, 30);
            this._lblDeutsch.Name = "_lblDeutsch";
            this._lblDeutsch.Size = new System.Drawing.Size(47, 13);
            this._lblDeutsch.TabIndex = 2;
            this._lblDeutsch.Text = "Deutsch";
            // 
            // _lblEnglisch
            // 
            this._lblEnglisch.AutoSize = true;
            this._lblEnglisch.Location = new System.Drawing.Point(211, 30);
            this._lblEnglisch.Name = "_lblEnglisch";
            this._lblEnglisch.Size = new System.Drawing.Size(47, 13);
            this._lblEnglisch.TabIndex = 2;
            this._lblEnglisch.Text = "Englisch";
            // 
            // DeutschComboBx
            // 
            this.DeutschComboBx.FormattingEnabled = true;
            this.DeutschComboBx.Location = new System.Drawing.Point(34, 46);
            this.DeutschComboBx.MaxDropDownItems = 6;
            this.DeutschComboBx.Name = "DeutschComboBx";
            this.DeutschComboBx.Size = new System.Drawing.Size(121, 21);
            this.DeutschComboBx.TabIndex = 1;
            // 
            // EnglischComboBx
            // 
            this.EnglischComboBx.FormattingEnabled = true;
            this.EnglischComboBx.Location = new System.Drawing.Point(177, 46);
            this.EnglischComboBx.MaxDropDownItems = 6;
            this.EnglischComboBx.Name = "EnglischComboBx";
            this.EnglischComboBx.Size = new System.Drawing.Size(121, 21);
            this.EnglischComboBx.TabIndex = 2;
            // 
            // NeuerEintrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.EnglischComboBx);
            this.Controls.Add(this.DeutschComboBx);
            this.Controls.Add(this._lblEnglisch);
            this.Controls.Add(this._lblDeutsch);
            this.Controls.Add(this._alterDatabaseBtn);
            this.Name = "NeuerEintrag";
            this.Size = new System.Drawing.Size(400, 225);
            this.Load += new System.EventHandler(this.NeuerEintrag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _alterDatabaseBtn;
        private System.Windows.Forms.Label _lblDeutsch;
        private System.Windows.Forms.Label _lblEnglisch;
        private System.Windows.Forms.ComboBox DeutschComboBx;
        private System.Windows.Forms.ComboBox EnglischComboBx;

    }
}
