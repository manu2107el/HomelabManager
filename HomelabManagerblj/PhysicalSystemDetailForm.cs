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
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            PhysicalSystemNameLabel.Text = physical.Name;
            PhysicalSystemStatusLabel.Text = physical.Status;
            IPDetailLabelShow.Text = physical.IP;
            AdminPanelDetailLabelShow.Text = physical.PortalLink;
            FindChildren();
            ChildrenCountLabel.Text = Convert.ToString(ListChildren());
        }
        public void FindChildren()
        {
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
            int i = 0;
            foreach (Virtual systemList in children)
            {

                ListViewItem item = new ListViewItem(new[] { systemList.Name, systemList.IP, systemList.Portal, systemList.Status, Convert.ToString(systemList.Mother) });
                this.ChildrenList.Items.Add(item);
                this.ChildrenList.Items[i].Group = this.ChildrenList.Groups[1];
                this.ChildrenList.Items[i].ImageIndex = systemList.StatusIconIndex;
                i++;

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
    }
}
