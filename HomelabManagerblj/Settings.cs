using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomelabManagerblj
{
    public partial class Settings : Form
    {
        OverviewForm overviewForm;
        public Settings(OverviewForm mainForm)
        {
            InitializeComponent();
            overviewForm = mainForm;
        }

        public void UpdateValues()
        {
            overviewForm.filehandler.IntegrityCheck();
            if (overviewForm.filehandler.PhysicalMissing)
            {
                PhysicalSaveFileStatus.Text = "MISSING";
            }
            if (overviewForm.filehandler.VirtualMissing)
            {
                VirtualSaveStatusIndicator.Text = "MISSING";
            }
            if (!overviewForm.filehandler.PhysicalMissing)
            {
                PhysicalSaveFileStatus.Text = "FOUND";
            }
            if (!overviewForm.filehandler.VirtualMissing)
            {
                VirtualSaveStatusIndicator.Text = "FOUND";
            }
            PhysicalPathLabel.Text = overviewForm.config.PhysicalSaveFile;
            VirtualFielPathIndicator.Text = overviewForm.config.VirtualSaveFile;
            OverviewPageBox.Text = overviewForm.config.overviewPage;
            TTLBox.Text = Convert.ToString(overviewForm.config.ttl);
            TimeoutBox.Text = Convert.ToString(overviewForm.config.timeout);
            Application.DoEvents();
        }

        

        private void ForgetPhysicalSave_Click(object sender, EventArgs e)
        {
            overviewForm.config.PhysicalSaveFile = "PhysicalList.xml";
            XmlSerializer PhysicalSaver = new XmlSerializer(typeof(List<Physical>));
            using (TextWriter writer = new StreamWriter(overviewForm.config.PhysicalSaveFile))
            {
                PhysicalSaver.Serialize(writer, overviewForm.PhysicalMain);
            }
            overviewForm.filehandler.SaveConfig();
            UpdateValues();
        }

        private void ForgetVirtual_Click(object sender, EventArgs e)
        {
            overviewForm.config.VirtualSaveFile = "VirtualList.xml";
            XmlSerializer VirtualSaver = new XmlSerializer(typeof(List<Virtual>));
            using (TextWriter writer = new StreamWriter(overviewForm.config.VirtualSaveFile))
            {
                VirtualSaver.Serialize(writer, overviewForm.VirtualMain);
            }
            overviewForm.filehandler.SaveConfig();
            UpdateValues();
             MessageBox.Show("Restart Application for chanches to be applied");
        }

        private void FindVirtual_Click(object sender, EventArgs e)
        {
            string message = "This will Discard any unsaved chanches!";
            string caption = "Continue?";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                OpenFileDialog searchVirtual = new OpenFileDialog();
                searchVirtual.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (searchVirtual.ShowDialog() == DialogResult.OK)
                {
                    overviewForm.config.VirtualSaveFile = searchVirtual.FileName;
                }
                overviewForm.filehandler.SaveConfig();
                UpdateValues1();
            }
           
            
        }

        private void FindPhysical_Click(object sender, EventArgs e)
        {
            string message = "This will Discard any unsaved chanches!";
            string caption = "Continue?";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
OpenFileDialog openPhysical = new OpenFileDialog();
            openPhysical.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openPhysical.ShowDialog() == DialogResult.OK)
            {
                overviewForm.config.PhysicalSaveFile = openPhysical.FileName;
            }
            overviewForm.filehandler.SaveConfig();
            UpdateValues1();
            }
            
        }
        public void ImportPhysical()
        {
            string importedListLocation = "";
            OpenFileDialog openPhysical = new OpenFileDialog();
            openPhysical.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openPhysical.ShowDialog() == DialogResult.OK)
            {
                importedListLocation = openPhysical.FileName;
                try
                {
                    overviewForm.PhysicalMain.AddRange(overviewForm.filehandler.OpenPhysicalConfig(importedListLocation));
                    overviewForm.Refresh();
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
        
            UpdateValues();
        }
        public void ImportVirtual()
        {
            string importedListLocation = "";
            OpenFileDialog openVirtual = new OpenFileDialog();
            openVirtual.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openVirtual.ShowDialog() == DialogResult.OK)
            {
                importedListLocation = openVirtual.FileName;
                try
                {
                    overviewForm.VirtualMain.AddRange(overviewForm.filehandler.OpenVirtualConfig(importedListLocation));
                    overviewForm.Refresh();
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }

            UpdateValues();
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            overviewForm.filehandler.SaveConfig();
            this.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportPhysical();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void ImportButton1_Click(object sender, EventArgs e)
        {
            ImportVirtual();
        }

        private void SaveOverviewPageButton_Click(object sender, EventArgs e)
        {
            overviewForm.config.overviewPage = OverviewPageBox.Text;
            overviewForm.filehandler.SaveConfig();
            UpdateValues();
        }

        private void PhysicalPathLabel_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", overviewForm.config.PhysicalSaveFile);
        }

        private void VirtualFielPathIndicator_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", overviewForm.config.VirtualSaveFile);
        }

        private void SetPing_Click(object sender, EventArgs e)
        {
            try
            {
                overviewForm.config.ttl = Convert.ToInt32(TTLBox.Text);
            }
            catch
            {
                MessageBox.Show("Error while Saving TTL");
            }
            try
            {
                overviewForm.config.timeout = Convert.ToInt32(TimeoutBox.Text);
            }
            catch
            {
                MessageBox.Show("Error while Saving Timeout");
            }
            overviewForm.filehandler.SaveConfig();
            UpdateValues();

        }
        public void UpdateValues1()
        {
            overviewForm.filehandler.IntegrityCheck();
            overviewForm.PhysicalMain = overviewForm.filehandler.ReadPhysicalSave();
            overviewForm.VirtualMain = overviewForm.filehandler.ReadVirtualSave();
            if (overviewForm.filehandler.PhysicalMissing)
            {
                PhysicalSaveFileStatus.Text = "MISSING";
            }
            if (overviewForm.filehandler.VirtualMissing)
            {
                VirtualSaveStatusIndicator.Text = "MISSING";
            }
            if (overviewForm.filehandler.PhysicalBroken)
            {
                PhysicalSaveFileStatus.Text = "UNREADABLE";
            }
            if (overviewForm.filehandler.VirtualBroken)
            {
                PhysicalSaveFileStatus.Text = "UNREADABLE";
            }
            if (!overviewForm.filehandler.PhysicalMissing && !overviewForm.filehandler.PhysicalBroken)
            {
                PhysicalSaveFileStatus.Text = "FOUND";
            }
            if (!overviewForm.filehandler.VirtualMissing && !overviewForm.filehandler.VirtualBroken)
            {
                VirtualSaveStatusIndicator.Text = "FOUND";
            }
            PhysicalPathLabel.Text = overviewForm.config.PhysicalSaveFile;
            VirtualFielPathIndicator.Text = overviewForm.config.VirtualSaveFile;
            OverviewPageBox.Text = overviewForm.config.overviewPage;
            TTLBox.Text = Convert.ToString(overviewForm.config.ttl);
            TimeoutBox.Text = Convert.ToString(overviewForm.config.timeout);
            Application.DoEvents();
        }
    }
}
