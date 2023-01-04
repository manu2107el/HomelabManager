using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomelabManagerblj
{ 
    public partial class OverviewForm : Form
    { 
        public List<Physical> PhysicalMain { get; set; }
        public List<Virtual> VirtualMain  { get; set; }
        Physical Mother;
        public Config config = new Config();
        public Filehandler filehandler = new Filehandler();

        public OverviewForm()
        {
            InitializeComponent();

            PhysicalMain = new List<Physical>();
            VirtualMain = new List<Virtual>();
        }

      

        private void Overview_Load(object sender, EventArgs e)
        {
            config = filehandler.LoadConfig();
            filehandler.IntegrityCheck();
            LoadLists();
            Refresh();
        }

        public void Refresh()
        {
            
            
            systemList.Items.Clear();
            int i = 0;
           
            
            
            foreach (Physical systemList in PhysicalMain)
            {
                systemList.StatusUpdate();
                ListViewItem item = new ListViewItem(new[] { systemList.Name, systemList.IP, systemList.Portal, Convert.ToString(systemList.Status), "Is Physical"});
                this.systemList.Items.Add(item);
               
                this.systemList.Items[i].Group = this.systemList.Groups[0];
                this.systemList.Items[i].ImageIndex = systemList.StatusIconIndex;
                i++;
               
            }
            foreach (Virtual systemList in VirtualMain)
            {
                systemList.StatusUpdate();
                ListViewItem item = new ListViewItem(new[] { systemList.Name, systemList.IP, systemList.Portal, systemList.Status, Convert.ToString(systemList.Mother) });
                this.systemList.Items.Add(item);
                this.systemList.Items[i].Group = this.systemList.Groups[1];
                this.systemList.Items[i].ImageIndex = systemList.StatusIconIndex;
                i++;
               
            }
            
        }
        
        private void CreateNewButton_Click(object sender, EventArgs e)
        {

            string newName = "";
            string newIP = "";
            string newPortal = "";

            bool motherSet = false;
            bool newNameSet = false;
            bool newIPSet = false;
            bool newPortalSet = false;
            bool ignorePortal = false;
            bool ignoreIP = false;
            if (NewPhsyicalRadioButton.Checked)
            {

                if (string.IsNullOrEmpty(NewName.Text))
                {
                    MessageBox.Show("Enter a Name for The System");
                }
                else if (string.IsNullOrEmpty(NewName.Text) == false)
                {
                    newName = NewName.Text;
                    newNameSet = true;
                }

                if (NoneBox1.Checked)
                {
                    ignoreIP = true;
                    newIPSet = true;
                }
                else if (NoneBox1.Checked == false)
                {
                    if (string.IsNullOrEmpty(NewIP.Text) == false)
                    {
                        newIP = NewIP.Text;
                        newIPSet = true;
                    }
                    else
                    {
                        MessageBox.Show("Pleas add an IP address");
                    }
                }
                if (NoneBox2.Checked)
                {
                    ignorePortal = true;
                    newPortalSet |= true;
                }
                else if (NoneBox2.Checked == false)
                {
                    if (string.IsNullOrEmpty(NewAddress.Text) == false)
                    {
                        newPortal = NewAddress.Text;
                        newPortalSet |= true;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter an address");
                    }
                }
                if (newIPSet && newNameSet && newPortalSet)
                {
                    Physical system = new Physical();
                    system.Name = newName;
                    system.IP = newIP;
                    system.Portal = newPortal;
                    system.IgnorePortal = ignorePortal;
                    system.IgnoreIP = ignoreIP;
                    PhysicalMain.Add(system);

                }
            }
            if (NewVirtualRadioButton.Checked)
            {
                Mother = MotherSelector.SelectedItem as Physical;
                

                if (string.IsNullOrEmpty(NewName.Text))
                {
                    MessageBox.Show("Enter a Name for The System");
                }
                else if (string.IsNullOrEmpty(NewName.Text) == false)
                {
                    newName = NewName.Text;
                    newNameSet = true;
                }

                if (NoneBox1.Checked)
                {
                    ignoreIP = true;
                    newIPSet = true;
                }
                else if (NoneBox1.Checked == false)
                {
                    if (string.IsNullOrEmpty(NewIP.Text) == false)
                    {
                        newIP = NewIP.Text;
                        newIPSet = true;
                    }
                    else
                    {
                        MessageBox.Show("Pleas add an IP address");
                    }
                }
                if (NoneBox2.Checked)
                {
                    ignorePortal = true;
                    newPortalSet |= true;
                }
                else if (NoneBox2.Checked == false)
                {
                    if (string.IsNullOrEmpty(NewAddress.Text) == false)
                    {
                        newPortal = NewAddress.Text;
                        newPortalSet |= true;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter an address");
                    }
                }
                if (newIPSet && newNameSet && newPortalSet)
                {
                    Virtual system = new Virtual();
                    system.Mother = MotherSelector.SelectedItem as Physical;
                    system.Name = newName;
                    system.IP = newIP;
                    system.Portal = newPortal;
                    system.IgnorePortal = ignorePortal;
                    system.IgnoreIP = ignoreIP;
                    VirtualMain.Add(system);

                }
            }
            MotherSelector.SelectedItem=null;
            NewAddress.Text = "";
            NewIP.Text = "";
            NewName.Text = "";
            MotherSelector.Items.Clear();
            foreach (Physical systemList in PhysicalMain)
            {
                MotherSelector.Items.Add(systemList);
            }

            Refresh();
        }
        public void OpenDetails()
        {
            
            foreach (ListViewItem item in systemList.SelectedItems)
            {
                Physical Psystem = PhysicalMain.FirstOrDefault(o => o.Name == item.Text);
                if (Psystem != null)
                {
                    PhysicalSystemDetailForm detailForm = new PhysicalSystemDetailForm(this, Psystem);
                    detailForm.Show();
                }
                Virtual vsystem = VirtualMain.FirstOrDefault(o => o.Name == item.Text);
                if (vsystem != null)
                {
                    VirtualSystemDetailForm detailForm = new VirtualSystemDetailForm(this, vsystem);
                    detailForm.Show();
                }
            }
        }
        public void DeleteItem()
        {
            foreach (ListViewItem item in systemList.CheckedItems)
            {
                Physical Psystem = PhysicalMain.FirstOrDefault(o => o.Name == item.Text);
                if (Psystem != null)
                {
                    PhysicalMain.Remove(Psystem);
                }
                Virtual vsystem = VirtualMain.FirstOrDefault(o => o.Name == item.Text);
                if (vsystem != null)
                {
                    VirtualMain.Remove(vsystem);
                }
            }
            foreach (ListViewItem item in systemList.SelectedItems)
            {
                Physical Psystem = PhysicalMain.FirstOrDefault(o => o.Name == item.Text);
                if (Psystem != null)
                {
                    PhysicalMain.Remove(Psystem);
                }
                Virtual vsystem = VirtualMain.FirstOrDefault(o => o.Name == item.Text);
                if (vsystem != null)
                {
                    VirtualMain.Remove(vsystem);
                }
            }

            Refresh();
        }
        public void SaveLists()
        {
            XmlSerializer PhysicalSaver = new XmlSerializer(typeof(List<Physical>));
            using (TextWriter writer = new StreamWriter("PhysicalList.xml"))
            {
                PhysicalSaver.Serialize(writer, PhysicalMain);
            }
            XmlSerializer VirtualSaver = new XmlSerializer(typeof(List<Virtual>));
            using (TextWriter writer = new StreamWriter("VirtualList.xml"))
            {
                VirtualSaver.Serialize(writer, VirtualMain);
            }
        }
        
        public void LoadLists()
        {
            PhysicalMain = filehandler.ReadPhysicalSave();
            VirtualMain = filehandler.ReadVirtualSave();
            if (filehandler.FileError) 
            { 
                MissingListDialog missingListDialog = new MissingListDialog(this);
                missingListDialog.ShowDialog();
            }

        }
        
        private void NewPhsyicalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NewPhsyicalRadioButton.Checked)
            {
                MotherSelector.Enabled = false;
            }
        }

        private void NewVirtualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NewVirtualRadioButton.Checked)
            {
                MotherSelector.Enabled = true;
            }
        }

        private void KumaPanelButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://status.wicki.sbs/status/systems");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void systemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteSystemsButton_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DetailViewButton_Click(object sender, EventArgs e)
        {
            OpenDetails();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveLists();
        }
    }
    
}
