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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualSystemDetailForm));
            this.VirtualSystemStatusLabel = new System.Windows.Forms.Label();
            this.IPDetailLabel = new System.Windows.Forms.Label();
            this.AdminPanelLabel = new System.Windows.Forms.Label();
            this.MotherLabel = new System.Windows.Forms.Label();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.VirtualSystemNameLabel = new System.Windows.Forms.TextBox();
            this.IPDetailLabelShow = new System.Windows.Forms.TextBox();
            this.AdminPanelDetailLabelShow = new System.Windows.Forms.TextBox();
            this.MotherChancher = new System.Windows.Forms.ComboBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.CopyIPButton = new System.Windows.Forms.Button();
            this.OpenAdminPanelButton = new System.Windows.Forms.Button();
            this.DisableIPCheckbox = new System.Windows.Forms.CheckBox();
            this.DisableAdminPanelCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VirtualSystemStatusLabel
            // 
            this.VirtualSystemStatusLabel.AutoSize = true;
            this.VirtualSystemStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualSystemStatusLabel.Location = new System.Drawing.Point(104, 169);
            this.VirtualSystemStatusLabel.Name = "VirtualSystemStatusLabel";
            this.VirtualSystemStatusLabel.Size = new System.Drawing.Size(126, 39);
            this.VirtualSystemStatusLabel.TabIndex = 10;
            this.VirtualSystemStatusLabel.Text = "Status:";
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
            // MotherLabel
            // 
            this.MotherLabel.AutoSize = true;
            this.MotherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherLabel.Location = new System.Drawing.Point(495, 12);
            this.MotherLabel.Name = "MotherLabel";
            this.MotherLabel.Size = new System.Drawing.Size(85, 25);
            this.MotherLabel.TabIndex = 12;
            this.MotherLabel.Text = "Mother:";
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.Location = new System.Drawing.Point(19, 138);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(79, 72);
            this.StatusPictureBox.TabIndex = 18;
            this.StatusPictureBox.TabStop = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "expired.png");
            this.imageList2.Images.SetKeyName(1, "status_connected.png");
            this.imageList2.Images.SetKeyName(2, "status_lagging.png");
            this.imageList2.Images.SetKeyName(3, "status_disconnected.png");
            // 
            // VirtualSystemNameLabel
            // 
            this.VirtualSystemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualSystemNameLabel.Location = new System.Drawing.Point(12, 12);
            this.VirtualSystemNameLabel.Name = "VirtualSystemNameLabel";
            this.VirtualSystemNameLabel.Size = new System.Drawing.Size(477, 35);
            this.VirtualSystemNameLabel.TabIndex = 1;
            // 
            // IPDetailLabelShow
            // 
            this.IPDetailLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPDetailLabelShow.Location = new System.Drawing.Point(248, 56);
            this.IPDetailLabelShow.Name = "IPDetailLabelShow";
            this.IPDetailLabelShow.Size = new System.Drawing.Size(241, 35);
            this.IPDetailLabelShow.TabIndex = 2;
            // 
            // AdminPanelDetailLabelShow
            // 
            this.AdminPanelDetailLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelDetailLabelShow.Location = new System.Drawing.Point(248, 97);
            this.AdminPanelDetailLabelShow.Name = "AdminPanelDetailLabelShow";
            this.AdminPanelDetailLabelShow.Size = new System.Drawing.Size(241, 35);
            this.AdminPanelDetailLabelShow.TabIndex = 5;
            // 
            // MotherChancher
            // 
            this.MotherChancher.FormattingEnabled = true;
            this.MotherChancher.ItemHeight = 13;
            this.MotherChancher.Location = new System.Drawing.Point(586, 16);
            this.MotherChancher.Name = "MotherChancher";
            this.MotherChancher.Size = new System.Drawing.Size(212, 21);
            this.MotherChancher.TabIndex = 9;
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(285, 138);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(166, 36);
            this.saveSettings.TabIndex = 8;
            this.saveSettings.Text = "Save Chanches and Update";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // CopyIPButton
            // 
            this.CopyIPButton.Location = new System.Drawing.Point(495, 71);
            this.CopyIPButton.Name = "CopyIPButton";
            this.CopyIPButton.Size = new System.Drawing.Size(74, 23);
            this.CopyIPButton.TabIndex = 4;
            this.CopyIPButton.Text = "Copy";
            this.CopyIPButton.UseVisualStyleBackColor = true;
            this.CopyIPButton.Click += new System.EventHandler(this.CopyIPButton_Click);
            // 
            // OpenAdminPanelButton
            // 
            this.OpenAdminPanelButton.Location = new System.Drawing.Point(494, 110);
            this.OpenAdminPanelButton.Name = "OpenAdminPanelButton";
            this.OpenAdminPanelButton.Size = new System.Drawing.Size(75, 23);
            this.OpenAdminPanelButton.TabIndex = 7;
            this.OpenAdminPanelButton.Text = "Open";
            this.OpenAdminPanelButton.UseVisualStyleBackColor = true;
            this.OpenAdminPanelButton.Click += new System.EventHandler(this.OpenAdminPanelButton_Click);
            // 
            // DisableIPCheckbox
            // 
            this.DisableIPCheckbox.AutoSize = true;
            this.DisableIPCheckbox.Location = new System.Drawing.Point(495, 56);
            this.DisableIPCheckbox.Name = "DisableIPCheckbox";
            this.DisableIPCheckbox.Size = new System.Drawing.Size(52, 17);
            this.DisableIPCheckbox.TabIndex = 3;
            this.DisableIPCheckbox.Text = "None";
            this.DisableIPCheckbox.UseVisualStyleBackColor = true;
            this.DisableIPCheckbox.CheckedChanged += new System.EventHandler(this.DisableIPCheckbox_CheckedChanged);
            // 
            // DisableAdminPanelCheckbox
            // 
            this.DisableAdminPanelCheckbox.AutoSize = true;
            this.DisableAdminPanelCheckbox.Location = new System.Drawing.Point(494, 97);
            this.DisableAdminPanelCheckbox.Name = "DisableAdminPanelCheckbox";
            this.DisableAdminPanelCheckbox.Size = new System.Drawing.Size(52, 17);
            this.DisableAdminPanelCheckbox.TabIndex = 6;
            this.DisableAdminPanelCheckbox.Text = "None";
            this.DisableAdminPanelCheckbox.UseVisualStyleBackColor = true;
            this.DisableAdminPanelCheckbox.CheckedChanged += new System.EventHandler(this.DisableAdminPanelCheckbox_CheckedChanged);
            // 
            // VirtualSystemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 217);
            this.Controls.Add(this.DisableAdminPanelCheckbox);
            this.Controls.Add(this.DisableIPCheckbox);
            this.Controls.Add(this.OpenAdminPanelButton);
            this.Controls.Add(this.CopyIPButton);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.MotherChancher);
            this.Controls.Add(this.AdminPanelDetailLabelShow);
            this.Controls.Add(this.IPDetailLabelShow);
            this.Controls.Add(this.VirtualSystemNameLabel);
            this.Controls.Add(this.StatusPictureBox);
            this.Controls.Add(this.VirtualSystemStatusLabel);
            this.Controls.Add(this.IPDetailLabel);
            this.Controls.Add(this.AdminPanelLabel);
            this.Controls.Add(this.MotherLabel);
            this.Name = "VirtualSystemDetailForm";
            this.Text = "VirtualSystemDetailForm";
            this.Load += new System.EventHandler(this.VirtualSystemDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VirtualSystemStatusLabel;
        private System.Windows.Forms.Label IPDetailLabel;
        private System.Windows.Forms.Label AdminPanelLabel;
        private System.Windows.Forms.Label MotherLabel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox VirtualSystemNameLabel;
        private System.Windows.Forms.TextBox IPDetailLabelShow;
        private System.Windows.Forms.TextBox AdminPanelDetailLabelShow;
        private System.Windows.Forms.ComboBox MotherChancher;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button CopyIPButton;
        private System.Windows.Forms.Button OpenAdminPanelButton;
        private System.Windows.Forms.CheckBox DisableIPCheckbox;
        private System.Windows.Forms.CheckBox DisableAdminPanelCheckbox;
    }
}