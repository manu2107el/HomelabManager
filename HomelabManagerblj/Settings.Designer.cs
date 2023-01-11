namespace HomelabManagerblj
{
    partial class Settings
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
            this.PhhsicalListLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.PhysicalPathLabel = new System.Windows.Forms.Label();
            this.PhysicalSaveFilePathLabel = new System.Windows.Forms.Label();
            this.FindPhysical = new System.Windows.Forms.Button();
            this.PhysicalSaveFileLabel = new System.Windows.Forms.Label();
            this.PhysicalSaveFileStatus = new System.Windows.Forms.Label();
            this.ForgetPhysicalSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImportButton1 = new System.Windows.Forms.Button();
            this.VirtualFielPathIndicator = new System.Windows.Forms.Label();
            this.VirtualFilePathLabel = new System.Windows.Forms.Label();
            this.FindVirtual = new System.Windows.Forms.Button();
            this.VirtualStatusLabel = new System.Windows.Forms.Label();
            this.VirtualSaveStatusIndicator = new System.Windows.Forms.Label();
            this.ForgetVirtual = new System.Windows.Forms.Button();
            this.OverviewWebsiteGroup = new System.Windows.Forms.GroupBox();
            this.SaveOverviewPageButton = new System.Windows.Forms.Button();
            this.OverviewPageBox = new System.Windows.Forms.TextBox();
            this.OverviewPageLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.TTLBox = new System.Windows.Forms.TextBox();
            this.SetPing = new System.Windows.Forms.Button();
            this.TimeoutBox = new System.Windows.Forms.TextBox();
            this.TTLLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.OverviewWebsiteGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhhsicalListLabel
            // 
            this.PhhsicalListLabel.AutoSize = true;
            this.PhhsicalListLabel.Location = new System.Drawing.Point(12, 29);
            this.PhhsicalListLabel.Name = "PhhsicalListLabel";
            this.PhhsicalListLabel.Size = new System.Drawing.Size(0, 13);
            this.PhhsicalListLabel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImportButton);
            this.groupBox1.Controls.Add(this.PhysicalPathLabel);
            this.groupBox1.Controls.Add(this.PhysicalSaveFilePathLabel);
            this.groupBox1.Controls.Add(this.FindPhysical);
            this.groupBox1.Controls.Add(this.PhysicalSaveFileLabel);
            this.groupBox1.Controls.Add(this.PhysicalSaveFileStatus);
            this.groupBox1.Controls.Add(this.ForgetPhysicalSave);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Physical Save File";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(105, 49);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(70, 23);
            this.ImportButton.TabIndex = 2;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // PhysicalPathLabel
            // 
            this.PhysicalPathLabel.AutoSize = true;
            this.PhysicalPathLabel.Location = new System.Drawing.Point(52, 33);
            this.PhysicalPathLabel.Name = "PhysicalPathLabel";
            this.PhysicalPathLabel.Size = new System.Drawing.Size(27, 13);
            this.PhysicalPathLabel.TabIndex = 6;
            this.PhysicalPathLabel.Text = "N/A";
            this.PhysicalPathLabel.Click += new System.EventHandler(this.PhysicalPathLabel_Click);
            // 
            // PhysicalSaveFilePathLabel
            // 
            this.PhysicalSaveFilePathLabel.AutoSize = true;
            this.PhysicalSaveFilePathLabel.Location = new System.Drawing.Point(6, 33);
            this.PhysicalSaveFilePathLabel.Name = "PhysicalSaveFilePathLabel";
            this.PhysicalSaveFilePathLabel.Size = new System.Drawing.Size(32, 13);
            this.PhysicalSaveFilePathLabel.TabIndex = 5;
            this.PhysicalSaveFilePathLabel.Text = "Path:";
            // 
            // FindPhysical
            // 
            this.FindPhysical.Location = new System.Drawing.Point(40, 49);
            this.FindPhysical.Name = "FindPhysical";
            this.FindPhysical.Size = new System.Drawing.Size(59, 23);
            this.FindPhysical.TabIndex = 1;
            this.FindPhysical.Text = "Open";
            this.FindPhysical.UseVisualStyleBackColor = true;
            this.FindPhysical.Click += new System.EventHandler(this.FindPhysical_Click);
            // 
            // PhysicalSaveFileLabel
            // 
            this.PhysicalSaveFileLabel.AutoSize = true;
            this.PhysicalSaveFileLabel.Location = new System.Drawing.Point(6, 16);
            this.PhysicalSaveFileLabel.Name = "PhysicalSaveFileLabel";
            this.PhysicalSaveFileLabel.Size = new System.Drawing.Size(40, 13);
            this.PhysicalSaveFileLabel.TabIndex = 2;
            this.PhysicalSaveFileLabel.Text = "Status:";
            // 
            // PhysicalSaveFileStatus
            // 
            this.PhysicalSaveFileStatus.AutoSize = true;
            this.PhysicalSaveFileStatus.Location = new System.Drawing.Point(52, 16);
            this.PhysicalSaveFileStatus.Name = "PhysicalSaveFileStatus";
            this.PhysicalSaveFileStatus.Size = new System.Drawing.Size(27, 13);
            this.PhysicalSaveFileStatus.TabIndex = 3;
            this.PhysicalSaveFileStatus.Text = "N/A";
            // 
            // ForgetPhysicalSave
            // 
            this.ForgetPhysicalSave.Location = new System.Drawing.Point(181, 49);
            this.ForgetPhysicalSave.Name = "ForgetPhysicalSave";
            this.ForgetPhysicalSave.Size = new System.Drawing.Size(148, 23);
            this.ForgetPhysicalSave.TabIndex = 3;
            this.ForgetPhysicalSave.Text = "Forget and Regenerate";
            this.ForgetPhysicalSave.UseVisualStyleBackColor = true;
            this.ForgetPhysicalSave.Click += new System.EventHandler(this.ForgetPhysicalSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImportButton1);
            this.groupBox2.Controls.Add(this.VirtualFielPathIndicator);
            this.groupBox2.Controls.Add(this.VirtualFilePathLabel);
            this.groupBox2.Controls.Add(this.FindVirtual);
            this.groupBox2.Controls.Add(this.VirtualStatusLabel);
            this.groupBox2.Controls.Add(this.VirtualSaveStatusIndicator);
            this.groupBox2.Controls.Add(this.ForgetVirtual);
            this.groupBox2.Location = new System.Drawing.Point(10, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Virtual Save File";
            // 
            // ImportButton1
            // 
            this.ImportButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImportButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImportButton1.Location = new System.Drawing.Point(107, 46);
            this.ImportButton1.Name = "ImportButton1";
            this.ImportButton1.Size = new System.Drawing.Size(70, 23);
            this.ImportButton1.TabIndex = 5;
            this.ImportButton1.Text = "Import";
            this.ImportButton1.UseVisualStyleBackColor = false;
            this.ImportButton1.Click += new System.EventHandler(this.ImportButton1_Click);
            // 
            // VirtualFielPathIndicator
            // 
            this.VirtualFielPathIndicator.AutoSize = true;
            this.VirtualFielPathIndicator.Location = new System.Drawing.Point(52, 33);
            this.VirtualFielPathIndicator.Name = "VirtualFielPathIndicator";
            this.VirtualFielPathIndicator.Size = new System.Drawing.Size(27, 13);
            this.VirtualFielPathIndicator.TabIndex = 6;
            this.VirtualFielPathIndicator.Text = "N/A";
            this.VirtualFielPathIndicator.Click += new System.EventHandler(this.VirtualFielPathIndicator_Click);
            // 
            // VirtualFilePathLabel
            // 
            this.VirtualFilePathLabel.AutoSize = true;
            this.VirtualFilePathLabel.Location = new System.Drawing.Point(6, 33);
            this.VirtualFilePathLabel.Name = "VirtualFilePathLabel";
            this.VirtualFilePathLabel.Size = new System.Drawing.Size(32, 13);
            this.VirtualFilePathLabel.TabIndex = 5;
            this.VirtualFilePathLabel.Text = "Path:";
            // 
            // FindVirtual
            // 
            this.FindVirtual.Location = new System.Drawing.Point(40, 46);
            this.FindVirtual.Name = "FindVirtual";
            this.FindVirtual.Size = new System.Drawing.Size(59, 23);
            this.FindVirtual.TabIndex = 4;
            this.FindVirtual.Text = "Open";
            this.FindVirtual.UseVisualStyleBackColor = true;
            this.FindVirtual.Click += new System.EventHandler(this.FindVirtual_Click);
            // 
            // VirtualStatusLabel
            // 
            this.VirtualStatusLabel.AutoSize = true;
            this.VirtualStatusLabel.Location = new System.Drawing.Point(6, 16);
            this.VirtualStatusLabel.Name = "VirtualStatusLabel";
            this.VirtualStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.VirtualStatusLabel.TabIndex = 2;
            this.VirtualStatusLabel.Text = "Status:";
            // 
            // VirtualSaveStatusIndicator
            // 
            this.VirtualSaveStatusIndicator.AutoSize = true;
            this.VirtualSaveStatusIndicator.Location = new System.Drawing.Point(52, 16);
            this.VirtualSaveStatusIndicator.Name = "VirtualSaveStatusIndicator";
            this.VirtualSaveStatusIndicator.Size = new System.Drawing.Size(27, 13);
            this.VirtualSaveStatusIndicator.TabIndex = 3;
            this.VirtualSaveStatusIndicator.Text = "N/A";
            // 
            // ForgetVirtual
            // 
            this.ForgetVirtual.Location = new System.Drawing.Point(183, 46);
            this.ForgetVirtual.Name = "ForgetVirtual";
            this.ForgetVirtual.Size = new System.Drawing.Size(148, 23);
            this.ForgetVirtual.TabIndex = 6;
            this.ForgetVirtual.Text = "Forget and Regenerate";
            this.ForgetVirtual.UseVisualStyleBackColor = true;
            this.ForgetVirtual.Click += new System.EventHandler(this.ForgetVirtual_Click);
            // 
            // OverviewWebsiteGroup
            // 
            this.OverviewWebsiteGroup.Controls.Add(this.SaveOverviewPageButton);
            this.OverviewWebsiteGroup.Controls.Add(this.OverviewPageBox);
            this.OverviewWebsiteGroup.Controls.Add(this.OverviewPageLabel);
            this.OverviewWebsiteGroup.Location = new System.Drawing.Point(10, 177);
            this.OverviewWebsiteGroup.Name = "OverviewWebsiteGroup";
            this.OverviewWebsiteGroup.Size = new System.Drawing.Size(337, 74);
            this.OverviewWebsiteGroup.TabIndex = 9;
            this.OverviewWebsiteGroup.TabStop = false;
            this.OverviewWebsiteGroup.Text = "Overview Website";
            // 
            // SaveOverviewPageButton
            // 
            this.SaveOverviewPageButton.Location = new System.Drawing.Point(256, 43);
            this.SaveOverviewPageButton.Name = "SaveOverviewPageButton";
            this.SaveOverviewPageButton.Size = new System.Drawing.Size(75, 23);
            this.SaveOverviewPageButton.TabIndex = 8;
            this.SaveOverviewPageButton.Text = "Set";
            this.SaveOverviewPageButton.UseVisualStyleBackColor = true;
            this.SaveOverviewPageButton.Click += new System.EventHandler(this.SaveOverviewPageButton_Click);
            // 
            // OverviewPageBox
            // 
            this.OverviewPageBox.Location = new System.Drawing.Point(98, 17);
            this.OverviewPageBox.Name = "OverviewPageBox";
            this.OverviewPageBox.Size = new System.Drawing.Size(231, 20);
            this.OverviewPageBox.TabIndex = 7;
            // 
            // OverviewPageLabel
            // 
            this.OverviewPageLabel.AutoSize = true;
            this.OverviewPageLabel.Location = new System.Drawing.Point(9, 20);
            this.OverviewPageLabel.Name = "OverviewPageLabel";
            this.OverviewPageLabel.Size = new System.Drawing.Size(83, 13);
            this.OverviewPageLabel.TabIndex = 0;
            this.OverviewPageLabel.Text = "Overview Page:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TimeoutLabel);
            this.groupBox3.Controls.Add(this.TTLBox);
            this.groupBox3.Controls.Add(this.SetPing);
            this.groupBox3.Controls.Add(this.TimeoutBox);
            this.groupBox3.Controls.Add(this.TTLLabel);
            this.groupBox3.Location = new System.Drawing.Point(10, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 74);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ping Time to Load";
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(9, 20);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(70, 13);
            this.TimeoutLabel.TabIndex = 10;
            this.TimeoutLabel.Text = "Timeout (ms):";
            // 
            // TTLBox
            // 
            this.TTLBox.Location = new System.Drawing.Point(85, 45);
            this.TTLBox.Name = "TTLBox";
            this.TTLBox.Size = new System.Drawing.Size(165, 20);
            this.TTLBox.TabIndex = 9;
            // 
            // SetPing
            // 
            this.SetPing.Location = new System.Drawing.Point(256, 29);
            this.SetPing.Name = "SetPing";
            this.SetPing.Size = new System.Drawing.Size(75, 23);
            this.SetPing.TabIndex = 8;
            this.SetPing.Text = "Set";
            this.SetPing.UseVisualStyleBackColor = true;
            this.SetPing.Click += new System.EventHandler(this.SetPing_Click);
            // 
            // TimeoutBox
            // 
            this.TimeoutBox.Location = new System.Drawing.Point(85, 17);
            this.TimeoutBox.Name = "TimeoutBox";
            this.TimeoutBox.Size = new System.Drawing.Size(165, 20);
            this.TimeoutBox.TabIndex = 7;
            // 
            // TTLLabel
            // 
            this.TTLLabel.AutoSize = true;
            this.TTLLabel.Location = new System.Drawing.Point(9, 48);
            this.TTLLabel.Name = "TTLLabel";
            this.TTLLabel.Size = new System.Drawing.Size(52, 13);
            this.TTLLabel.TabIndex = 0;
            this.TTLLabel.Text = "TTL (ms):";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(356, 353);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OverviewWebsiteGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PhhsicalListLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.OverviewWebsiteGroup.ResumeLayout(false);
            this.OverviewWebsiteGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhhsicalListLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PhysicalPathLabel;
        private System.Windows.Forms.Label PhysicalSaveFilePathLabel;
        private System.Windows.Forms.Button FindPhysical;
        private System.Windows.Forms.Label PhysicalSaveFileLabel;
        private System.Windows.Forms.Label PhysicalSaveFileStatus;
        private System.Windows.Forms.Button ForgetPhysicalSave;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ImportButton1;
        private System.Windows.Forms.Label VirtualFielPathIndicator;
        private System.Windows.Forms.Label VirtualFilePathLabel;
        private System.Windows.Forms.Button FindVirtual;
        private System.Windows.Forms.Label VirtualStatusLabel;
        private System.Windows.Forms.Label VirtualSaveStatusIndicator;
        private System.Windows.Forms.Button ForgetVirtual;
        private System.Windows.Forms.GroupBox OverviewWebsiteGroup;
        private System.Windows.Forms.Label OverviewPageLabel;
        private System.Windows.Forms.Button SaveOverviewPageButton;
        private System.Windows.Forms.TextBox OverviewPageBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SetPing;
        private System.Windows.Forms.TextBox TimeoutBox;
        private System.Windows.Forms.Label TTLLabel;
        private System.Windows.Forms.Label TimeoutLabel;
        private System.Windows.Forms.TextBox TTLBox;
    }
}