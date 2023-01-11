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
    public partial class VirtualSystemDetailForm : Form
    {
        
        Virtual system;
        OverviewForm overviewForm;
        List<Virtual> children = new List<Virtual>();
        public VirtualSystemDetailForm(OverviewForm form, Virtual Sys)
        {
            InitializeComponent();
            
            overviewForm = form;
            this.system = Sys;
        }

        private void VirtualSystemDetailForm_Load(object sender, EventArgs e)
        {
            Refresh();
            if (system.IgnoreIP)
            {
                DisableIPCheckbox.Checked = true;
            }
            if (system.IgnorePortal)
            {
                DisableAdminPanelCheckbox.Checked = true;
            }
        }
        public void Save()
        {
            if (DisableIPCheckbox.Checked)
            {
                system.IgnoreIP = true;
            }
            if (!DisableIPCheckbox.Checked)
            {
                system.IP = IPDetailLabelShow.Text;
                system.IgnoreIP =false;
            }
            if (DisableAdminPanelCheckbox.Checked)
            {
                system.IgnorePortal = true;
            }
            if (!DisableAdminPanelCheckbox.Checked)
            {
                system.PortalLink = AdminPanelDetailLabelShow.Text;
                system.IgnorePortal = false;
            }
            system.Name = VirtualSystemNameLabel.Text;
            system.Mother = MotherChancher.SelectedItem as Physical;
            system.SelfRepair();
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
                IPDetailLabelShow.Text = system.IP;
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
                AdminPanelDetailLabelShow.Text = system.PortalLink;
            }

            VirtualSystemNameLabel.Text = system.Name;
            VirtualSystemStatusLabel.Text = system.Status;
            FillMotherSelector();
            StatusPictureBox.Image = imageList2.Images[system.StatusIconIndex];
            overviewForm.Refresh();
        }
        public void FillMotherSelector()
        {
            int i = 0;
            int j = 0;
            MotherChancher.Items.Clear();
            foreach (Physical systemList in overviewForm.PhysicalMain)
            {
               MotherChancher.Items.Add(systemList);
                if (system.Mother != null)
                {
                    if (systemList.Name == system.Mother.Name)
                    {
                        j = i;
                        MotherChancher.SelectedItem = systemList;
                    }
                }
                
                i++;
            }
            
        }
        private void AdminPanelDetailLabelShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(system.PortalLink);
        }

        private void MotherOfSystemLabel_Click(object sender, EventArgs e)
        {
            PhysicalSystemDetailForm detailForm = new PhysicalSystemDetailForm(overviewForm, system.Mother);
            detailForm.Show();
        }

        private void CopyIPButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(system.IP);
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            Save();
            Refresh();
        }

        private void OpenAdminPanelButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(system.PortalLink);
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
