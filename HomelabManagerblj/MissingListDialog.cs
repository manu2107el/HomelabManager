using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomelabManagerblj
{
    public partial class MissingListDialog : Form
    {
        OverviewForm OverviewFormlocal;
       
        
        public MissingListDialog(OverviewForm overviewForm)
        {
            InitializeComponent();
            
            OverviewFormlocal = overviewForm;
            
        }
        public void UpdateValues()
        {
            OverviewFormlocal.filehandler.IntegrityCheck();
            OverviewFormlocal.PhysicalMain=OverviewFormlocal.filehandler.ReadPhysicalSave();
            OverviewFormlocal.VirtualMain=OverviewFormlocal.filehandler.ReadVirtualSave();
            if (OverviewFormlocal.filehandler.PhysicalMissing)
            {
                PhysicalSaveFileStatus.Text = "MISSING";
            }
            if (OverviewFormlocal.filehandler.VirtualMissing)
            {
                VirtualSaveStatusIndicator.Text = "MISSING";
            }
            if (OverviewFormlocal.filehandler.PhysicalBroken)
            {
                PhysicalSaveFileStatus.Text = "UNREADABLE";
            }
            if (OverviewFormlocal.filehandler.VirtualBroken)
            {
                PhysicalSaveFileStatus.Text = "UNREADABLE";
            }
            if (!OverviewFormlocal.filehandler.PhysicalMissing && !OverviewFormlocal.filehandler.PhysicalBroken)
            {
                PhysicalSaveFileStatus.Text = "FOUND";
            }
            if (!OverviewFormlocal.filehandler.VirtualMissing && !OverviewFormlocal.filehandler.VirtualBroken)
            {
                VirtualSaveStatusIndicator.Text = "FOUND";
            }
            PhysicalPathLabel.Text = OverviewFormlocal.config.PhysicalSaveFile;
            VirtualFielPathIndicator.Text = OverviewFormlocal.config.VirtualSaveFile;
            Application.DoEvents();
        }

        private void MissingListDialog_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void ForgetPhysicalSave_Click(object sender, EventArgs e)
        {
            
            OverviewFormlocal.config.PhysicalSaveFile = "PhysicalList.xml";
            XmlSerializer PhysicalSaver = new XmlSerializer(typeof(List<Physical>));
            using (TextWriter writer = new StreamWriter(OverviewFormlocal.config.PhysicalSaveFile))
            {
                PhysicalSaver.Serialize(writer, OverviewFormlocal.PhysicalMain);
            }
            OverviewFormlocal.filehandler.SaveConfig();
            UpdateValues();
        }

        private void ForgetVirtual_Click(object sender, EventArgs e)
        {
            OverviewFormlocal.config.VirtualSaveFile = "VirtualList.xml";
            XmlSerializer VirtualSaver = new XmlSerializer(typeof(List<Virtual>));
            using (TextWriter writer = new StreamWriter(OverviewFormlocal.config.VirtualSaveFile))
            {
                VirtualSaver.Serialize(writer, OverviewFormlocal.VirtualMain);
            }
            OverviewFormlocal.filehandler.SaveConfig();
            UpdateValues();
        }

        private void FindVirtual_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchVirtual = new OpenFileDialog();
            searchVirtual.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (searchVirtual.ShowDialog() == DialogResult.OK)
            {
                OverviewFormlocal.config.VirtualSaveFile = searchVirtual.FileName;
            }
            OverviewFormlocal.filehandler.SaveConfig();
            UpdateValues();
        }

        private void FindPhysical_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openPhysical = new OpenFileDialog();
            openPhysical.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openPhysical.ShowDialog() == DialogResult.OK)
            {
                OverviewFormlocal.config.PhysicalSaveFile = openPhysical.FileName;
            }
            OverviewFormlocal.filehandler.SaveConfig();
            UpdateValues();
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            OverviewFormlocal.filehandler.SaveConfig();
            this.Close();
        }
    }
}
