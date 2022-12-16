namespace HomelabManagerblj
{
    partial class NewSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTestButton = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.NoneBox2 = new System.Windows.Forms.CheckBox();
            this.NoneBox1 = new System.Windows.Forms.CheckBox();
            this.NewManagementPortalLabel = new System.Windows.Forms.Label();
            this.NewIPAddressLabel = new System.Windows.Forms.Label();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.MotherSystemLabel = new System.Windows.Forms.Label();
            this.MotherSelector = new System.Windows.Forms.ComboBox();
            this.NewIP = new System.Windows.Forms.TextBox();
            this.NewAddress = new System.Windows.Forms.TextBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.NewVirtualRadioButton = new System.Windows.Forms.RadioButton();
            this.NewPhsyicalRadioButton = new System.Windows.Forms.RadioButton();
            this.SendToMainBar = new System.Windows.Forms.ProgressBar();
            this.NewCloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewCloseButton);
            this.panel1.Controls.Add(this.SendToMainBar);
            this.panel1.Controls.Add(this.NewTestButton);
            this.panel1.Controls.Add(this.CreateNewButton);
            this.panel1.Controls.Add(this.NoneBox2);
            this.panel1.Controls.Add(this.NoneBox1);
            this.panel1.Controls.Add(this.NewManagementPortalLabel);
            this.panel1.Controls.Add(this.NewIPAddressLabel);
            this.panel1.Controls.Add(this.NewNameLabel);
            this.panel1.Controls.Add(this.MotherSystemLabel);
            this.panel1.Controls.Add(this.MotherSelector);
            this.panel1.Controls.Add(this.NewIP);
            this.panel1.Controls.Add(this.NewAddress);
            this.panel1.Controls.Add(this.NewName);
            this.panel1.Controls.Add(this.NewVirtualRadioButton);
            this.panel1.Controls.Add(this.NewPhsyicalRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(448, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 512);
            this.panel1.TabIndex = 3;
            // 
            // NewTestButton
            // 
            this.NewTestButton.Location = new System.Drawing.Point(3, 231);
            this.NewTestButton.Name = "NewTestButton";
            this.NewTestButton.Size = new System.Drawing.Size(75, 23);
            this.NewTestButton.TabIndex = 13;
            this.NewTestButton.Text = "Test";
            this.NewTestButton.UseVisualStyleBackColor = true;
            this.NewTestButton.Click += new System.EventHandler(this.NewTestButton_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(84, 231);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(75, 23);
            this.CreateNewButton.TabIndex = 12;
            this.CreateNewButton.Text = "Create";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // NoneBox2
            // 
            this.NoneBox2.AutoSize = true;
            this.NoneBox2.Location = new System.Drawing.Point(248, 206);
            this.NoneBox2.Name = "NoneBox2";
            this.NoneBox2.Size = new System.Drawing.Size(52, 17);
            this.NoneBox2.TabIndex = 11;
            this.NoneBox2.Text = "None";
            this.NoneBox2.UseVisualStyleBackColor = true;
            // 
            // NoneBox1
            // 
            this.NoneBox1.AutoSize = true;
            this.NoneBox1.Location = new System.Drawing.Point(248, 167);
            this.NoneBox1.Name = "NoneBox1";
            this.NoneBox1.Size = new System.Drawing.Size(52, 17);
            this.NoneBox1.TabIndex = 10;
            this.NoneBox1.Text = "None";
            this.NoneBox1.UseVisualStyleBackColor = true;
            // 
            // NewManagementPortalLabel
            // 
            this.NewManagementPortalLabel.AutoSize = true;
            this.NewManagementPortalLabel.Location = new System.Drawing.Point(3, 188);
            this.NewManagementPortalLabel.Name = "NewManagementPortalLabel";
            this.NewManagementPortalLabel.Size = new System.Drawing.Size(99, 13);
            this.NewManagementPortalLabel.TabIndex = 9;
            this.NewManagementPortalLabel.Text = "Management Portal";
            // 
            // NewIPAddressLabel
            // 
            this.NewIPAddressLabel.AutoSize = true;
            this.NewIPAddressLabel.Location = new System.Drawing.Point(3, 149);
            this.NewIPAddressLabel.Name = "NewIPAddressLabel";
            this.NewIPAddressLabel.Size = new System.Drawing.Size(58, 13);
            this.NewIPAddressLabel.TabIndex = 8;
            this.NewIPAddressLabel.Text = "IP Address";
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Location = new System.Drawing.Point(3, 111);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(35, 13);
            this.NewNameLabel.TabIndex = 7;
            this.NewNameLabel.Text = "Name";
            // 
            // MotherSystemLabel
            // 
            this.MotherSystemLabel.AutoSize = true;
            this.MotherSystemLabel.Location = new System.Drawing.Point(3, 70);
            this.MotherSystemLabel.Name = "MotherSystemLabel";
            this.MotherSystemLabel.Size = new System.Drawing.Size(77, 13);
            this.MotherSystemLabel.TabIndex = 6;
            this.MotherSystemLabel.Text = "Mother System";
            // 
            // MotherSelector
            // 
            this.MotherSelector.FormattingEnabled = true;
            this.MotherSelector.Location = new System.Drawing.Point(3, 86);
            this.MotherSelector.Name = "MotherSelector";
            this.MotherSelector.Size = new System.Drawing.Size(238, 21);
            this.MotherSelector.TabIndex = 5;
            this.MotherSelector.SelectedIndexChanged += new System.EventHandler(this.MotherSelector_SelectedIndexChanged);
            // 
            // NewIP
            // 
            this.NewIP.Location = new System.Drawing.Point(3, 165);
            this.NewIP.Name = "NewIP";
            this.NewIP.Size = new System.Drawing.Size(238, 20);
            this.NewIP.TabIndex = 4;
            // 
            // NewAddress
            // 
            this.NewAddress.Location = new System.Drawing.Point(3, 204);
            this.NewAddress.Name = "NewAddress";
            this.NewAddress.Size = new System.Drawing.Size(238, 20);
            this.NewAddress.TabIndex = 3;
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(3, 127);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(238, 20);
            this.NewName.TabIndex = 2;
            this.NewName.Tag = "";
            // 
            // NewVirtualRadioButton
            // 
            this.NewVirtualRadioButton.AutoSize = true;
            this.NewVirtualRadioButton.Location = new System.Drawing.Point(33, 23);
            this.NewVirtualRadioButton.Name = "NewVirtualRadioButton";
            this.NewVirtualRadioButton.Size = new System.Drawing.Size(54, 17);
            this.NewVirtualRadioButton.TabIndex = 1;
            this.NewVirtualRadioButton.TabStop = true;
            this.NewVirtualRadioButton.Text = "Virtual";
            this.NewVirtualRadioButton.UseVisualStyleBackColor = true;
            this.NewVirtualRadioButton.CheckedChanged += new System.EventHandler(this.NewVirtualRadioButton_CheckedChanged);
            // 
            // NewPhsyicalRadioButton
            // 
            this.NewPhsyicalRadioButton.AutoSize = true;
            this.NewPhsyicalRadioButton.Location = new System.Drawing.Point(132, 23);
            this.NewPhsyicalRadioButton.Name = "NewPhsyicalRadioButton";
            this.NewPhsyicalRadioButton.Size = new System.Drawing.Size(64, 17);
            this.NewPhsyicalRadioButton.TabIndex = 0;
            this.NewPhsyicalRadioButton.TabStop = true;
            this.NewPhsyicalRadioButton.Text = "Physical";
            this.NewPhsyicalRadioButton.UseVisualStyleBackColor = true;
            this.NewPhsyicalRadioButton.CheckedChanged += new System.EventHandler(this.NewPhsyicalRadioButton_CheckedChanged);
            // 
            // SendToMainBar
            // 
            this.SendToMainBar.Location = new System.Drawing.Point(0, 269);
            this.SendToMainBar.Name = "SendToMainBar";
            this.SendToMainBar.Size = new System.Drawing.Size(241, 23);
            this.SendToMainBar.TabIndex = 14;
            // 
            // NewCloseButton
            // 
            this.NewCloseButton.Location = new System.Drawing.Point(165, 231);
            this.NewCloseButton.Name = "NewCloseButton";
            this.NewCloseButton.Size = new System.Drawing.Size(75, 23);
            this.NewCloseButton.TabIndex = 15;
            this.NewCloseButton.Text = "Close";
            this.NewCloseButton.UseVisualStyleBackColor = true;
            this.NewCloseButton.Click += new System.EventHandler(this.NewCloseButton_Click);
            // 
            // NewSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 512);
            this.Controls.Add(this.panel1);
            this.Name = "NewSystem";
            this.Text = "NewSystem";
            this.Load += new System.EventHandler(this.NewSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NewIP;
        private System.Windows.Forms.TextBox NewAddress;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.RadioButton NewVirtualRadioButton;
        private System.Windows.Forms.RadioButton NewPhsyicalRadioButton;
        private System.Windows.Forms.ComboBox MotherSelector;
        private System.Windows.Forms.Label MotherSystemLabel;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.Label NewManagementPortalLabel;
        private System.Windows.Forms.Label NewIPAddressLabel;
        private System.Windows.Forms.CheckBox NoneBox2;
        private System.Windows.Forms.CheckBox NoneBox1;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button NewTestButton;
        private System.Windows.Forms.Button NewCloseButton;
        private System.Windows.Forms.ProgressBar SendToMainBar;
    }
}