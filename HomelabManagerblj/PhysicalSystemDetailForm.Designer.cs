namespace HomelabManagerblj
{
    partial class PhysicalSystemDetailForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Physical Systems", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Virtual Systems", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicalSystemDetailForm));
            this.PhysicalSystemNameLabel = new System.Windows.Forms.Label();
            this.ChildrenList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManagementPortalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MotherCollum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChildrenLabel = new System.Windows.Forms.Label();
            this.ChildrenCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPDetailLabel = new System.Windows.Forms.Label();
            this.AdminPanelDetailLabelShow = new System.Windows.Forms.Label();
            this.IPDetailLabelShow = new System.Windows.Forms.Label();
            this.PhysicalSystemStatusLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhysicalSystemNameLabel
            // 
            this.PhysicalSystemNameLabel.AutoSize = true;
            this.PhysicalSystemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalSystemNameLabel.Location = new System.Drawing.Point(12, 9);
            this.PhysicalSystemNameLabel.Name = "PhysicalSystemNameLabel";
            this.PhysicalSystemNameLabel.Size = new System.Drawing.Size(248, 39);
            this.PhysicalSystemNameLabel.TabIndex = 0;
            this.PhysicalSystemNameLabel.Text = "System Name";
            // 
            // ChildrenList
            // 
            this.ChildrenList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ChildrenList.AllowColumnReorder = true;
            this.ChildrenList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.IPColumn,
            this.ManagementPortalColumn,
            this.StatusColumn,
            this.MotherCollum});
            this.ChildrenList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChildrenList.FullRowSelect = true;
            this.ChildrenList.GridLines = true;
            listViewGroup1.Header = "Physical Systems";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Virtual Systems";
            listViewGroup2.Name = "listViewGroup2";
            this.ChildrenList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ChildrenList.HideSelection = false;
            this.ChildrenList.Location = new System.Drawing.Point(0, 179);
            this.ChildrenList.Name = "ChildrenList";
            this.ChildrenList.Size = new System.Drawing.Size(815, 303);
            this.ChildrenList.SmallImageList = this.imageList1;
            this.ChildrenList.TabIndex = 2;
            this.ChildrenList.UseCompatibleStateImageBehavior = false;
            this.ChildrenList.View = System.Windows.Forms.View.Details;
            this.ChildrenList.DoubleClick += new System.EventHandler(this.ChildrenList_DoubleClick);
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
            // ChildrenLabel
            // 
            this.ChildrenLabel.AutoSize = true;
            this.ChildrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenLabel.Location = new System.Drawing.Point(12, 137);
            this.ChildrenLabel.Name = "ChildrenLabel";
            this.ChildrenLabel.Size = new System.Drawing.Size(156, 39);
            this.ChildrenLabel.TabIndex = 3;
            this.ChildrenLabel.Text = "Children:";
            // 
            // ChildrenCountLabel
            // 
            this.ChildrenCountLabel.AutoSize = true;
            this.ChildrenCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenCountLabel.Location = new System.Drawing.Point(241, 137);
            this.ChildrenCountLabel.Name = "ChildrenCountLabel";
            this.ChildrenCountLabel.Size = new System.Drawing.Size(75, 39);
            this.ChildrenCountLabel.TabIndex = 4;
            this.ChildrenCountLabel.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Panel:";
            // 
            // IPDetailLabel
            // 
            this.IPDetailLabel.AutoSize = true;
            this.IPDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPDetailLabel.Location = new System.Drawing.Point(12, 59);
            this.IPDetailLabel.Name = "IPDetailLabel";
            this.IPDetailLabel.Size = new System.Drawing.Size(59, 39);
            this.IPDetailLabel.TabIndex = 6;
            this.IPDetailLabel.Text = "IP:";
            // 
            // AdminPanelDetailLabelShow
            // 
            this.AdminPanelDetailLabelShow.AutoSize = true;
            this.AdminPanelDetailLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelDetailLabelShow.Location = new System.Drawing.Point(241, 98);
            this.AdminPanelDetailLabelShow.Name = "AdminPanelDetailLabelShow";
            this.AdminPanelDetailLabelShow.Size = new System.Drawing.Size(75, 39);
            this.AdminPanelDetailLabelShow.TabIndex = 7;
            this.AdminPanelDetailLabelShow.Text = "N/A";
            this.AdminPanelDetailLabelShow.Click += new System.EventHandler(this.AdminPanelDetailLabelShow_Click);
            // 
            // IPDetailLabelShow
            // 
            this.IPDetailLabelShow.AutoSize = true;
            this.IPDetailLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPDetailLabelShow.Location = new System.Drawing.Point(241, 59);
            this.IPDetailLabelShow.Name = "IPDetailLabelShow";
            this.IPDetailLabelShow.Size = new System.Drawing.Size(75, 39);
            this.IPDetailLabelShow.TabIndex = 8;
            this.IPDetailLabelShow.Text = "N/A";
            // 
            // PhysicalSystemStatusLabel
            // 
            this.PhysicalSystemStatusLabel.AutoSize = true;
            this.PhysicalSystemStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhysicalSystemStatusLabel.Location = new System.Drawing.Point(643, 9);
            this.PhysicalSystemStatusLabel.Name = "PhysicalSystemStatusLabel";
            this.PhysicalSystemStatusLabel.Size = new System.Drawing.Size(116, 39);
            this.PhysicalSystemStatusLabel.TabIndex = 1;
            this.PhysicalSystemStatusLabel.Text = "Status";
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
            // StatusPictureBox
            // 
            this.StatusPictureBox.Location = new System.Drawing.Point(650, 51);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(108, 75);
            this.StatusPictureBox.TabIndex = 9;
            this.StatusPictureBox.TabStop = false;
            // 
            // PhysicalSystemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 482);
            this.Controls.Add(this.StatusPictureBox);
            this.Controls.Add(this.IPDetailLabelShow);
            this.Controls.Add(this.AdminPanelDetailLabelShow);
            this.Controls.Add(this.IPDetailLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChildrenCountLabel);
            this.Controls.Add(this.ChildrenLabel);
            this.Controls.Add(this.ChildrenList);
            this.Controls.Add(this.PhysicalSystemStatusLabel);
            this.Controls.Add(this.PhysicalSystemNameLabel);
            this.Name = "PhysicalSystemDetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhysicalSystemNameLabel;
        private System.Windows.Forms.ListView ChildrenList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader IPColumn;
        private System.Windows.Forms.ColumnHeader ManagementPortalColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.ColumnHeader MotherCollum;
        private System.Windows.Forms.Label ChildrenLabel;
        private System.Windows.Forms.Label ChildrenCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IPDetailLabel;
        private System.Windows.Forms.Label AdminPanelDetailLabelShow;
        private System.Windows.Forms.Label IPDetailLabelShow;
        private System.Windows.Forms.Label PhysicalSystemStatusLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox StatusPictureBox;
    }
}