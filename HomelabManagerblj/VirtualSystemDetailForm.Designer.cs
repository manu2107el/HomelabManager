namespace HomelabManagerblj
{
    partial class VirtualSystemDetailForm
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
            this.VirtualSystemStatusLabel = new System.Windows.Forms.Label();
            this.VirtualSystemNameLabel = new System.Windows.Forms.Label();
            this.IPDetailLabelShow = new System.Windows.Forms.Label();
            this.AdminPanelDetailLabelShow = new System.Windows.Forms.Label();
            this.IPDetailLabel = new System.Windows.Forms.Label();
            this.AdminPanelLabel = new System.Windows.Forms.Label();
            this.MotherOfSystemLabel = new System.Windows.Forms.Label();
            this.MotherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VirtualSystemStatusLabel
            // 
            this.VirtualSystemStatusLabel.AutoSize = true;
            this.VirtualSystemStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualSystemStatusLabel.Location = new System.Drawing.Point(12, 172);
            this.VirtualSystemStatusLabel.Name = "VirtualSystemStatusLabel";
            this.VirtualSystemStatusLabel.Size = new System.Drawing.Size(116, 39);
            this.VirtualSystemStatusLabel.TabIndex = 10;
            this.VirtualSystemStatusLabel.Text = "Status";
            // 
            // VirtualSystemNameLabel
            // 
            this.VirtualSystemNameLabel.AutoSize = true;
            this.VirtualSystemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualSystemNameLabel.Location = new System.Drawing.Point(12, 5);
            this.VirtualSystemNameLabel.Name = "VirtualSystemNameLabel";
            this.VirtualSystemNameLabel.Size = new System.Drawing.Size(248, 39);
            this.VirtualSystemNameLabel.TabIndex = 9;
            this.VirtualSystemNameLabel.Text = "System Name";
            // 
            // IPDetailLabelShow
            // 
            this.IPDetailLabelShow.AutoSize = true;
            this.IPDetailLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPDetailLabelShow.Location = new System.Drawing.Point(241, 55);
            this.IPDetailLabelShow.Name = "IPDetailLabelShow";
            this.IPDetailLabelShow.Size = new System.Drawing.Size(75, 39);
            this.IPDetailLabelShow.TabIndex = 17;
            this.IPDetailLabelShow.Text = "N/A";
            // 
            // AdminPanelDetailLabelShow
            // 
            this.AdminPanelDetailLabelShow.AutoSize = true;
            this.AdminPanelDetailLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelDetailLabelShow.Location = new System.Drawing.Point(241, 94);
            this.AdminPanelDetailLabelShow.Name = "AdminPanelDetailLabelShow";
            this.AdminPanelDetailLabelShow.Size = new System.Drawing.Size(75, 39);
            this.AdminPanelDetailLabelShow.TabIndex = 16;
            this.AdminPanelDetailLabelShow.Text = "N/A";
            // 
            // IPDetailLabel
            // 
            this.IPDetailLabel.AutoSize = true;
            this.IPDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPDetailLabel.Location = new System.Drawing.Point(12, 55);
            this.IPDetailLabel.Name = "IPDetailLabel";
            this.IPDetailLabel.Size = new System.Drawing.Size(59, 39);
            this.IPDetailLabel.TabIndex = 15;
            this.IPDetailLabel.Text = "IP:";
            // 
            // AdminPanelLabel
            // 
            this.AdminPanelLabel.AutoSize = true;
            this.AdminPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelLabel.Location = new System.Drawing.Point(12, 94);
            this.AdminPanelLabel.Name = "AdminPanelLabel";
            this.AdminPanelLabel.Size = new System.Drawing.Size(223, 39);
            this.AdminPanelLabel.TabIndex = 14;
            this.AdminPanelLabel.Text = "Admin Panel:";
            // 
            // MotherOfSystemLabel
            // 
            this.MotherOfSystemLabel.AutoSize = true;
            this.MotherOfSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherOfSystemLabel.Location = new System.Drawing.Point(241, 133);
            this.MotherOfSystemLabel.Name = "MotherOfSystemLabel";
            this.MotherOfSystemLabel.Size = new System.Drawing.Size(75, 39);
            this.MotherOfSystemLabel.TabIndex = 13;
            this.MotherOfSystemLabel.Text = "N/A";
            this.MotherOfSystemLabel.Click += new System.EventHandler(this.MotherOfSystemLabel_Click);
            // 
            // MotherLabel
            // 
            this.MotherLabel.AutoSize = true;
            this.MotherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherLabel.Location = new System.Drawing.Point(12, 133);
            this.MotherLabel.Name = "MotherLabel";
            this.MotherLabel.Size = new System.Drawing.Size(135, 39);
            this.MotherLabel.TabIndex = 12;
            this.MotherLabel.Text = "Mother:";
            // 
            // VirtualSystemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 224);
            this.Controls.Add(this.VirtualSystemStatusLabel);
            this.Controls.Add(this.VirtualSystemNameLabel);
            this.Controls.Add(this.IPDetailLabelShow);
            this.Controls.Add(this.AdminPanelDetailLabelShow);
            this.Controls.Add(this.IPDetailLabel);
            this.Controls.Add(this.AdminPanelLabel);
            this.Controls.Add(this.MotherOfSystemLabel);
            this.Controls.Add(this.MotherLabel);
            this.Name = "VirtualSystemDetailForm";
            this.Text = "VirtualSystemDetailForm";
            this.Load += new System.EventHandler(this.VirtualSystemDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VirtualSystemStatusLabel;
        private System.Windows.Forms.Label VirtualSystemNameLabel;
        private System.Windows.Forms.Label IPDetailLabelShow;
        private System.Windows.Forms.Label AdminPanelDetailLabelShow;
        private System.Windows.Forms.Label IPDetailLabel;
        private System.Windows.Forms.Label AdminPanelLabel;
        private System.Windows.Forms.Label MotherOfSystemLabel;
        private System.Windows.Forms.Label MotherLabel;
    }
}