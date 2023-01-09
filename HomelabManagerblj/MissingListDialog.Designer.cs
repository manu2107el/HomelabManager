namespace HomelabManagerblj
{
    partial class MissingListDialog
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
            this.MissingLabel = new System.Windows.Forms.Label();
            this.ForgetPhysicalSave = new System.Windows.Forms.Button();
            this.PhysicalSaveFileLabel = new System.Windows.Forms.Label();
            this.PhysicalSaveFileStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhysicalPathLabel = new System.Windows.Forms.Label();
            this.PhysicalSaveFilePathLabel = new System.Windows.Forms.Label();
            this.FindPhysical = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VirtualFielPathIndicator = new System.Windows.Forms.Label();
            this.VirtualFilePathLabel = new System.Windows.Forms.Label();
            this.FindVirtual = new System.Windows.Forms.Button();
            this.VirtualStatusLabel = new System.Windows.Forms.Label();
            this.VirtualSaveStatusIndicator = new System.Windows.Forms.Label();
            this.ForgetVirtual = new System.Windows.Forms.Button();
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MissingLabel
            // 
            this.MissingLabel.AutoSize = true;
            this.MissingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingLabel.Location = new System.Drawing.Point(24, 24);
            this.MissingLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MissingLabel.Name = "MissingLabel";
            this.MissingLabel.Size = new System.Drawing.Size(558, 31);
            this.MissingLabel.TabIndex = 0;
            this.MissingLabel.Text = "One or More of the save files Are missing!";
            // 
            // ForgetPhysicalSave
            // 
            this.ForgetPhysicalSave.Location = new System.Drawing.Point(352, 20);
            this.ForgetPhysicalSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ForgetPhysicalSave.Name = "ForgetPhysicalSave";
            this.ForgetPhysicalSave.Size = new System.Drawing.Size(255, 42);
            this.ForgetPhysicalSave.TabIndex = 2;
            this.ForgetPhysicalSave.Text = "Forget and Regenerate";
            this.ForgetPhysicalSave.UseVisualStyleBackColor = true;
            this.ForgetPhysicalSave.Click += new System.EventHandler(this.ForgetPhysicalSave_Click);
            // 
            // PhysicalSaveFileLabel
            // 
            this.PhysicalSaveFileLabel.AutoSize = true;
            this.PhysicalSaveFileLabel.Location = new System.Drawing.Point(11, 30);
            this.PhysicalSaveFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhysicalSaveFileLabel.Name = "PhysicalSaveFileLabel";
            this.PhysicalSaveFileLabel.Size = new System.Drawing.Size(74, 25);
            this.PhysicalSaveFileLabel.TabIndex = 2;
            this.PhysicalSaveFileLabel.Text = "Status:";
            // 
            // PhysicalSaveFileStatus
            // 
            this.PhysicalSaveFileStatus.AutoSize = true;
            this.PhysicalSaveFileStatus.Location = new System.Drawing.Point(95, 30);
            this.PhysicalSaveFileStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhysicalSaveFileStatus.Name = "PhysicalSaveFileStatus";
            this.PhysicalSaveFileStatus.Size = new System.Drawing.Size(46, 25);
            this.PhysicalSaveFileStatus.TabIndex = 3;
            this.PhysicalSaveFileStatus.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhysicalPathLabel);
            this.groupBox1.Controls.Add(this.PhysicalSaveFilePathLabel);
            this.groupBox1.Controls.Add(this.FindPhysical);
            this.groupBox1.Controls.Add(this.PhysicalSaveFileLabel);
            this.groupBox1.Controls.Add(this.PhysicalSaveFileStatus);
            this.groupBox1.Controls.Add(this.ForgetPhysicalSave);
            this.groupBox1.Location = new System.Drawing.Point(29, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(618, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Physical Save File";
            // 
            // PhysicalPathLabel
            // 
            this.PhysicalPathLabel.AutoSize = true;
            this.PhysicalPathLabel.Location = new System.Drawing.Point(95, 61);
            this.PhysicalPathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhysicalPathLabel.Name = "PhysicalPathLabel";
            this.PhysicalPathLabel.Size = new System.Drawing.Size(46, 25);
            this.PhysicalPathLabel.TabIndex = 6;
            this.PhysicalPathLabel.Text = "N/A";
            // 
            // PhysicalSaveFilePathLabel
            // 
            this.PhysicalSaveFilePathLabel.AutoSize = true;
            this.PhysicalSaveFilePathLabel.Location = new System.Drawing.Point(16, 61);
            this.PhysicalSaveFilePathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PhysicalSaveFilePathLabel.Name = "PhysicalSaveFilePathLabel";
            this.PhysicalSaveFilePathLabel.Size = new System.Drawing.Size(58, 25);
            this.PhysicalSaveFilePathLabel.TabIndex = 5;
            this.PhysicalSaveFilePathLabel.Text = "Path:";
            // 
            // FindPhysical
            // 
            this.FindPhysical.Location = new System.Drawing.Point(233, 20);
            this.FindPhysical.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FindPhysical.Name = "FindPhysical";
            this.FindPhysical.Size = new System.Drawing.Size(108, 42);
            this.FindPhysical.TabIndex = 1;
            this.FindPhysical.Text = "Find";
            this.FindPhysical.UseVisualStyleBackColor = true;
            this.FindPhysical.Click += new System.EventHandler(this.FindPhysical_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VirtualFielPathIndicator);
            this.groupBox2.Controls.Add(this.VirtualFilePathLabel);
            this.groupBox2.Controls.Add(this.FindVirtual);
            this.groupBox2.Controls.Add(this.VirtualStatusLabel);
            this.groupBox2.Controls.Add(this.VirtualSaveStatusIndicator);
            this.groupBox2.Controls.Add(this.ForgetVirtual);
            this.groupBox2.Location = new System.Drawing.Point(29, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(618, 107);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Virtual Save File";
            // 
            // VirtualFielPathIndicator
            // 
            this.VirtualFielPathIndicator.AutoSize = true;
            this.VirtualFielPathIndicator.Location = new System.Drawing.Point(95, 61);
            this.VirtualFielPathIndicator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VirtualFielPathIndicator.Name = "VirtualFielPathIndicator";
            this.VirtualFielPathIndicator.Size = new System.Drawing.Size(46, 25);
            this.VirtualFielPathIndicator.TabIndex = 6;
            this.VirtualFielPathIndicator.Text = "N/A";
            // 
            // VirtualFilePathLabel
            // 
            this.VirtualFilePathLabel.AutoSize = true;
            this.VirtualFilePathLabel.Location = new System.Drawing.Point(16, 61);
            this.VirtualFilePathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VirtualFilePathLabel.Name = "VirtualFilePathLabel";
            this.VirtualFilePathLabel.Size = new System.Drawing.Size(58, 25);
            this.VirtualFilePathLabel.TabIndex = 5;
            this.VirtualFilePathLabel.Text = "Path:";
            // 
            // FindVirtual
            // 
            this.FindVirtual.Location = new System.Drawing.Point(233, 20);
            this.FindVirtual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FindVirtual.Name = "FindVirtual";
            this.FindVirtual.Size = new System.Drawing.Size(108, 42);
            this.FindVirtual.TabIndex = 3;
            this.FindVirtual.Text = "Find";
            this.FindVirtual.UseVisualStyleBackColor = true;
            this.FindVirtual.Click += new System.EventHandler(this.FindVirtual_Click);
            // 
            // VirtualStatusLabel
            // 
            this.VirtualStatusLabel.AutoSize = true;
            this.VirtualStatusLabel.Location = new System.Drawing.Point(11, 30);
            this.VirtualStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VirtualStatusLabel.Name = "VirtualStatusLabel";
            this.VirtualStatusLabel.Size = new System.Drawing.Size(74, 25);
            this.VirtualStatusLabel.TabIndex = 2;
            this.VirtualStatusLabel.Text = "Status:";
            // 
            // VirtualSaveStatusIndicator
            // 
            this.VirtualSaveStatusIndicator.AutoSize = true;
            this.VirtualSaveStatusIndicator.Location = new System.Drawing.Point(95, 30);
            this.VirtualSaveStatusIndicator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VirtualSaveStatusIndicator.Name = "VirtualSaveStatusIndicator";
            this.VirtualSaveStatusIndicator.Size = new System.Drawing.Size(46, 25);
            this.VirtualSaveStatusIndicator.TabIndex = 3;
            this.VirtualSaveStatusIndicator.Text = "N/A";
            // 
            // ForgetVirtual
            // 
            this.ForgetVirtual.Location = new System.Drawing.Point(352, 20);
            this.ForgetVirtual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ForgetVirtual.Name = "ForgetVirtual";
            this.ForgetVirtual.Size = new System.Drawing.Size(255, 42);
            this.ForgetVirtual.TabIndex = 4;
            this.ForgetVirtual.Text = "Forget and Regenerate";
            this.ForgetVirtual.UseVisualStyleBackColor = true;
            this.ForgetVirtual.Click += new System.EventHandler(this.ForgetVirtual_Click);
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Location = new System.Drawing.Point(438, 321);
            this.SaveAndClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(209, 42);
            this.SaveAndClose.TabIndex = 5;
            this.SaveAndClose.Text = "Close and Continue";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // MissingListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 384);
            this.Controls.Add(this.SaveAndClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MissingLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MissingListDialog";
            this.Text = "MissingListDialog";
            this.Load += new System.EventHandler(this.MissingListDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MissingLabel;
        private System.Windows.Forms.Button ForgetPhysicalSave;
        private System.Windows.Forms.Label PhysicalSaveFileLabel;
        private System.Windows.Forms.Label PhysicalSaveFileStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PhysicalSaveFilePathLabel;
        private System.Windows.Forms.Button FindPhysical;
        private System.Windows.Forms.Label PhysicalPathLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label VirtualFielPathIndicator;
        private System.Windows.Forms.Label VirtualFilePathLabel;
        private System.Windows.Forms.Button FindVirtual;
        private System.Windows.Forms.Label VirtualStatusLabel;
        private System.Windows.Forms.Label VirtualSaveStatusIndicator;
        private System.Windows.Forms.Button ForgetVirtual;
        private System.Windows.Forms.Button SaveAndClose;
    }
}