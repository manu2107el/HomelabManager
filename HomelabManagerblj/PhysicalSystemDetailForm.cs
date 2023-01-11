using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomelabManagerblj
{
    public partial class PhysicalSystemDetailForm : Form
    {
        Physical physical;
        OverviewForm overviewForm;
        List<Virtual> children = new List<Virtual>();
        
        public PhysicalSystemDetailForm(OverviewForm form, Physical system)
        {
            InitializeComponent();
            overviewForm = form;
            physical = system;
            this.KeyUp += new KeyEventHandler(Form_KeyUp);
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            
            if (physical.IgnoreIP)
            {
                DisableIPCheckbox.Checked = true;
            }
            if (physical.IgnorePortal)
            {
                DisableAdminPanelCheckbox.Checked = true;
            }
            Refresh();
        }
        public void Save()
        {
            if (DisableIPCheckbox.Checked)
            {
                physical.IgnoreIP = true;
            }
            if (!DisableIPCheckbox.Checked)
            {
                physical.IP = IPDetailLabelShow.Text;
                physical.IgnoreIP = false;
            }
            if (DisableAdminPanelCheckbox.Checked)
            {
                physical.IgnorePortal = true;
            }
            if (!DisableAdminPanelCheckbox.Checked)
            {
                physical.PortalLink = AdminPanelDetailLabelShow.Text;
                physical.IgnorePortal = false;
            }
            physical.Name = PhysicalSystemNameLabel.Text;
            physical.SelfRepair();
        }
        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
                Refresh();
            }
        }
        public void Refresh()
        {
            if (DisableIPCheckbox.Checked)
            {
                IPDetailLabelShow.Enabled = false;
                CopyIPButton.Enabled = false;
                IPDetailLabelShow.Text = "";
            }
            if (!DisableIPCheckbox.Checked)
            {
                IPDetailLabelShow.Enabled = true;
                CopyIPButton.Enabled = true;
                IPDetailLabelShow.Text = physical.IP;
            }
            if (DisableAdminPanelCheckbox.Checked)
            {
                AdminPanelDetailLabelShow.Enabled = false;
                OpenAdminPanelButton.Enabled = false;
                AdminPanelDetailLabelShow.Text = "";
            }
            if (!DisableAdminPanelCheckbox.Checked)
            {
                AdminPanelDetailLabelShow.Enabled = true;
                OpenAdminPanelButton.Enabled = true;
                AdminPanelDetailLabelShow.Text = physical.PortalLink;
            }
            
            PhysicalSystemNameLabel.Text = physical.Name;
            PhysicalSystemStatusLabel.Text = physical.Status;
            FindChildren();
                ChildrenCountLabel.Text = Convert.ToString(ListChildren());
            
            StatusPictureBox.Image = imageList2.Images[physical.StatusIconIndex];
            overviewForm.Refresh();
            Application.DoEvents();
        }
        public void FindChildren()
        {
            children.Clear();
            foreach(Virtual system in overviewForm.VirtualMain)
            {
                if (system.Mother.Name == physical.Name)
                {
                    children.Add(system);
                }
            }
        }
       
        public int ListChildren()
        {
            ChildrenList.Items.Clear();
           
            int i = 0;
            foreach (Virtual systemList in children)
            {

                ListViewItem item = new ListViewItem(new[] { systemList.Name, systemList.IP, systemList.Portal, systemList.Status, Convert.ToString(systemList.Mother) });
                this.ChildrenList.Items.Add(item);
                this.ChildrenList.Items[i].Group = this.ChildrenList.Groups[1];
                this.ChildrenList.Items[i].ImageIndex = systemList.StatusIconIndex;
                i++;
                Application.DoEvents();
            }
            return i;
        }

        private void AdminPanelDetailLabelShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(physical.PortalLink);
        }

        private void ChildrenList_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ChildrenList.SelectedItems)
            {
                Physical Psystem = overviewForm.PhysicalMain.FirstOrDefault(o => o.Name == item.Text);
                if (Psystem != null)
                {
                    PhysicalSystemDetailForm detailForm = new PhysicalSystemDetailForm(overviewForm, Psystem);
                    detailForm.Show();
                }
                Virtual vsystem = overviewForm.VirtualMain.FirstOrDefault(o => o.Name == item.Text);
                if (vsystem != null)
                {
                    VirtualSystemDetailForm detailForm = new VirtualSystemDetailForm(overviewForm,  vsystem);
                    detailForm.Show();
                }
            }
        }
       

        private void saveSettings_Click(object sender, EventArgs e)
        {
            saveSettings.Enabled = false;
            Save();
            Refresh();
            saveSettings.Enabled = true;
        }

        private void OpenAdminPanelButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(physical.PortalLink);
        }

        private void CopyIPButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(physical.IP);
        }

        private void DisableIPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DisableAdminPanelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

       
    }
}
