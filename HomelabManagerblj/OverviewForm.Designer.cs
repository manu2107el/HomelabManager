namespace HomelabManagerblj
{
    partial class OverviewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Physical Systems", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Virtual Systems", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenSettings = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.DetailViewButton = new System.Windows.Forms.Button();
            this.DeleteSystemsButton = new System.Windows.Forms.Button();
            this.OpenSettingsButton = new System.Windows.Forms.Button();
            this.KumaPanelButton = new System.Windows.Forms.Button();
            this.systemList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManagementPortalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MotherCollum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.OpenSettings);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.DetailViewButton);
            this.panel1.Controls.Add(this.DeleteSystemsButton);
            this.panel1.Controls.Add(this.OpenSettingsButton);
            this.panel1.Controls.Add(this.KumaPanelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 65);
            this.panel1.TabIndex = 0;
            // 
            // OpenSettings
            // 
            this.OpenSettings.Location = new System.Drawing.Point(570, 14);
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(114, 35);
            this.OpenSettings.TabIndex = 5;
            this.OpenSettings.Text = "Settings";
            this.OpenSettings.UseVisualStyleBackColor = true;
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(428, 14);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 35);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DetailViewButton
            // 
            this.DetailViewButton.Location = new System.Drawing.Point(289, 14);
            this.DetailViewButton.Name = "DetailViewButton";
            this.DetailViewButton.Size = new System.Drawing.Size(133, 35);
            this.DetailViewButton.TabIndex = 3;
            this.DetailViewButton.Text = "Open Details";
            this.DetailViewButton.UseVisualStyleBackColor = true;
            this.DetailViewButton.Click += new System.EventHandler(this.DetailViewButton_Click);
            // 
            // DeleteSystemsButton
            // 
            this.DeleteSystemsButton.Location = new System.Drawing.Point(139, 14);
            this.DeleteSystemsButton.Name = "DeleteSystemsButton";
            this.DeleteSystemsButton.Size = new System.Drawing.Size(144, 35);
            this.DeleteSystemsButton.TabIndex = 2;
            this.DeleteSystemsButton.Text = "Delete Selected Systems";
            this.DeleteSystemsButton.UseVisualStyleBackColor = true;
            this.DeleteSystemsButton.Click += new System.EventHandler(this.DeleteSystemsButton_Click);
            // 
            // OpenSettingsButton
            // 
            this.OpenSettingsButton.Location = new System.Drawing.Point(12, 14);
            this.OpenSettingsButton.Name = "OpenSettingsButton";
            this.OpenSettingsButton.Size = new System.Drawing.Size(121, 35);
            this.OpenSettingsButton.TabIndex = 1;
            this.OpenSettingsButton.Text = "Refresh";
            this.OpenSettingsButton.UseVisualStyleBackColor = true;
            this.OpenSettingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // KumaPanelButton
            // 
            this.KumaPanelButton.Location = new System.Drawing.Point(1091, 12);
            this.KumaPanelButton.Name = "KumaPanelButton";
            this.KumaPanelButton.Size = new System.Drawing.Size(148, 39);
            this.KumaPanelButton.TabIndex = 0;
            this.KumaPanelButton.Text = "Launch Overview Panel";
            this.KumaPanelButton.UseVisualStyleBackColor = true;
            this.KumaPanelButton.Click += new System.EventHandler(this.KumaPanelButton_Click);
            // 
            // systemList
            // 
            this.systemList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.systemList.AllowColumnReorder = true;
            this.systemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.IPColumn,
            this.ManagementPortalColumn,
            this.StatusColumn,
            this.MotherCollum});
            this.systemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemList.FullRowSelect = true;
            this.systemList.GridLines = true;
            listViewGroup1.Header = "Physical Systems";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Virtual Systems";
            listViewGroup2.Name = "listViewGroup2";
            this.systemList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.systemList.HideSelection = false;
            this.systemList.Location = new System.Drawing.Point(0, 65);
            this.systemList.Name = "systemList";
            this.systemList.Size = new System.Drawing.Size(1251, 492);
            this.systemList.SmallImageList = this.imageList1;
            this.systemList.TabIndex = 1;
            this.systemList.UseCompatibleStateImageBehavior = false;
            this.systemList.View = System.Windows.Forms.View.Details;
            this.systemList.SelectedIndexChanged += new System.EventHandler(this.systemList_SelectedIndexChanged);
            this.systemList.DoubleClick += new System.EventHandler(this.DetailViewButton_Click);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 226;
            // 
            // IPColumn
            // 
            this.IPColumn.Text = "IP";
            this.IPColumn.Width = 168;
            // 
            // ManagementPortalColumn
            // 
            this.ManagementPortalColumn.Text = "ManagementPortal";
            this.ManagementPortalColumn.Width = 168;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 275;
            // 
            // MotherCollum
            // 
            this.MotherCollum.Text = "Mother";
            this.MotherCollum.Width = 104;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "expired.png");
            this.imageList1.Images.SetKeyName(1, "status_connected.png");
            this.imageList1.Images.SetKeyName(2, "status_lagging.png");
            this.imageList1.Images.SetKeyName(3, "status_disconnected.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CreateNewButton);
            this.panel2.Controls.Add(this.NoneBox2);
            this.panel2.Controls.Add(this.NoneBox1);
            this.panel2.Controls.Add(this.NewManagementPortalLabel);
            this.panel2.Controls.Add(this.NewIPAddressLabel);
            this.panel2.Controls.Add(this.NewNameLabel);
            this.panel2.Controls.Add(this.MotherSystemLabel);
            this.panel2.Controls.Add(this.MotherSelector);
            this.panel2.Controls.Add(this.NewIP);
            this.panel2.Controls.Add(this.NewAddress);
            this.panel2.Controls.Add(this.NewName);
            this.panel2.Controls.Add(this.NewVirtualRadioButton);
            this.panel2.Controls.Add(this.NewPhsyicalRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(945, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 492);
            this.panel2.TabIndex = 4;
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(6, 231);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(235, 23);
            this.CreateNewButton.TabIndex = 7;
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
            this.NoneBox2.TabIndex = 5;
            this.NoneBox2.Text = "None";
            this.NoneBox2.UseVisualStyleBackColor = true;
            this.NoneBox2.CheckedChanged += new System.EventHandler(this.NoneBox2_CheckedChanged);
            // 
            // NoneBox1
            // 
            this.NoneBox1.AutoSize = true;
            this.NoneBox1.Location = new System.Drawing.Point(248, 167);
            this.NoneBox1.Name = "NoneBox1";
            this.NoneBox1.Size = new System.Drawing.Size(52, 17);
            this.NoneBox1.TabIndex = 4;
            this.NoneBox1.Text = "None";
            this.NoneBox1.UseVisualStyleBackColor = true;
            this.NoneBox1.CheckedChanged += new System.EventHandler(this.NoneBox1_CheckedChanged);
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
            this.MotherSelector.TabIndex = 1;
            // 
            // NewIP
            // 
            this.NewIP.Location = new System.Drawing.Point(3, 165);
            this.NewIP.Name = "NewIP";
            this.NewIP.Size = new System.Drawing.Size(238, 20);
            this.NewIP.TabIndex = 3;
            // 
            // NewAddress
            // 
            this.NewAddress.Location = new System.Drawing.Point(3, 204);
            this.NewAddress.Name = "NewAddress";
            this.NewAddress.Size = new System.Drawing.Size(238, 20);
            this.NewAddress.TabIndex = 4;
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
            this.NewVirtualRadioButton.TabIndex = 9;
            this.NewVirtualRadioButton.TabStop = true;
            this.NewVirtualRadioButton.Text = "Virtual";
            this.NewVirtualRadioButton.UseVisualStyleBackColor = true;
            this.NewVirtualRadioButton.CheckedChanged += new System.EventHandler(this.NewVirtualRadioButton_CheckedChanged_1);
            this.NewVirtualRadioButton.Click += new System.EventHandler(this.NewVirtualRadioButton_CheckedChanged);
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
            this.NewPhsyicalRadioButton.CheckedChanged += new System.EventHandler(this.NewPhsyicalRadioButton_CheckedChanged_1);
            this.NewPhsyicalRadioButton.Click += new System.EventHandler(this.NewPhsyicalRadioButton_CheckedChanged);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.systemList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverviewForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KumaPanelButton;
        private System.Windows.Forms.ListView systemList;
        private System.Windows.Forms.ColumnHeader IPColumn;
        private System.Windows.Forms.ColumnHeader ManagementPortalColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.CheckBox NoneBox2;
        private System.Windows.Forms.CheckBox NoneBox1;
        private System.Windows.Forms.Label NewManagementPortalLabel;
        private System.Windows.Forms.Label NewIPAddressLabel;
        private System.Windows.Forms.Label NewNameLabel;
        private System.Windows.Forms.Label MotherSystemLabel;
        private System.Windows.Forms.ComboBox MotherSelector;
        private System.Windows.Forms.TextBox NewIP;
        private System.Windows.Forms.TextBox NewAddress;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.RadioButton NewVirtualRadioButton;
        private System.Windows.Forms.RadioButton NewPhsyicalRadioButton;
        private System.Windows.Forms.ColumnHeader MotherCollum;
        private System.Windows.Forms.Button OpenSettingsButton;
        private System.Windows.Forms.Button DeleteSystemsButton;
        private System.Windows.Forms.Button DetailViewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.Button OpenSettings;
    }
}

