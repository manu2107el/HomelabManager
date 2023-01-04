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
            VirtualSystemNameLabel.Text = system.Name;
            VirtualSystemStatusLabel.Text = system.Status;
            IPDetailLabelShow.Text = system.IP;
            AdminPanelDetailLabelShow.Text = system.PortalLink;
            MotherOfSystemLabel.Text = system.Mother.Name;
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
    }
}
