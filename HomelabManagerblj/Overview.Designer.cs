namespace HomelabManagerblj
{
    partial class Overview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewSystemButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewSystemButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 73);
            this.panel1.TabIndex = 0;
            // 
            // NewSystemButton
            // 
            this.NewSystemButton.Location = new System.Drawing.Point(1015, 25);
            this.NewSystemButton.Name = "NewSystemButton";
            this.NewSystemButton.Size = new System.Drawing.Size(75, 23);
            this.NewSystemButton.TabIndex = 0;
            this.NewSystemButton.Text = "ADD";
            this.NewSystemButton.UseVisualStyleBackColor = true;
            this.NewSystemButton.Click += new System.EventHandler(this.NewSystemButton_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 543);
            this.Controls.Add(this.panel1);
            this.Name = "Overview";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewSystemButton;
    }
}

