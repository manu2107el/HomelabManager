using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomelabManagerblj
{
    public partial class OverviewForm : Form
    {
        public List<Physical> PhysicalMain { get; set; }
        public List<Virtual> VirtualMain { get; set; }
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
                systemList.StatusUpdate(config.ttl, config.timeout);
                ListViewItem item = new ListViewItem(new[] { systemList.Name, systemList.IP, systemList.Portal, Convert.ToString(systemList.Status), "Is Physical" });
                this.systemList.Items.Add(item);

                this.systemList.Items[i].Group = this.systemList.Groups[0];
                this.systemList.Items[i].ImageIndex = systemList.StatusIconIndex;
                i++;

            }
            foreach (Virtual systemList in VirtualMain)
            {
                systemList.StatusUpdate(config.ttl, config.timeout);
                ListViewItem item = new ListViewItem(new[] { systemList.Name, systemList.IP, systemList.Portal, systemList.Status, Convert.ToString(systemList.Mother) });
                this.systemList.Items.Add(item);
                this.systemList.Items[i].Group = this.systemList.Groups[1];
                this.systemList.Items[i].ImageIndex = systemList.StatusIconIndex;
                i++;

            }
            MotherSelector.Items.Clear();
            foreach (Physical systemList in PhysicalMain)
            {
                MotherSelector.Items.Add(systemList);
            }
            if (!NewPhsyicalRadioButton.Checked && !NewVirtualRadioButton.Checked)
            {
                CreateNewButton.Enabled = false;
            }
            if (NewVirtualRadioButton.Checked || NewPhsyicalRadioButton.Checked)
            {
                CreateNewButton.Enabled = true;
            }

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
            using (TextWriter writer = new StreamWriter(config.PhysicalSaveFile))
            {
                PhysicalSaver.Serialize(writer, PhysicalMain);
            }
            XmlSerializer VirtualSaver = new XmlSerializer(typeof(List<Virtual>));
            using (TextWriter writer = new StreamWriter(config.VirtualSaveFile))
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
            try
            {
                System.Diagnostics.Process.Start(config.overviewPage);
            }
            catch
            {
                MessageBox.Show("Please Make sure there is a Valid Web Link\n(with http(s)://)  Saved in Settings -> Overview Website");
            }
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
        private void LoadTheme()
        {
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel2.BackColor = SystemColors.ControlDarkDark;
        }
        private void CreateNewButton_Click(object sender, EventArgs e)
        {

            string newName = "";
            string newIP = "";
            string newPortal = "";
            string newPortalLink = "";

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
                        if (IsValidIP(newIP))
                        {
                            newIPSet = true;
                        }
                        else
                        {
                            MessageBox.Show("IP is invalid");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pleas add an IP address");
                    }
                }
                if (NoneBox2.Checked)
                {
                    ignorePortal = true;
                    newPortalSet = true;
                }
                else if (NoneBox2.Checked == false)
                {
                    if (string.IsNullOrEmpty(NewAddress.Text) == false)
                    {
                        newPortalLink = NewAddress.Text;
                        Match match = Regex.Match(newPortalLink, @"(?:[\d]{1,3})\.(?:[\d]{1,3})\.(?:[\d]{1,3})\.(?:[\d]{1,3})|(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}");

                        if (match.Success)
                        {
                            newPortal = match.Value;
                            newPortalSet = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Make sure your link is valid (with http(s)://)");
                            newPortal = "Invalid.Set";
                        }

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
                    system.PortalLink = newPortalLink;
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
                        if (IsValidIP(newIP))
                        {
                            newIPSet = true;
                        }
                        else
                        {
                            MessageBox.Show("IP is invalid");
                        }
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
                        newPortalLink = NewAddress.Text;
                        Match match = Regex.Match(newPortalLink, @"(?:[\d]{1,3})\.(?:[\d]{1,3})\.(?:[\d]{1,3})\.(?:[\d]{1,3})|(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}");

                        if (match.Success)
                        {
                            newPortal = match.Value;
                            newPortalSet = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Make sure your link is valid (with http(s)://)");
                            newPortal = "Invalid.Set";
                        }

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
                    system.PortalLink = newPortalLink;
                    system.IgnorePortal = ignorePortal;
                    system.IgnoreIP = ignoreIP;
                    VirtualMain.Add(system);

                }
            }
            MotherSelector.SelectedItem = null;
            NewAddress.Text = "";
            NewIP.Text = "";
            NewName.Text = "";
            MotherSelector.Items.Clear();
            foreach (Physical systemList in PhysicalMain)
            {
                MotherSelector.Items.Add(systemList);
            }
            this.ActiveControl = NewName;
            Refresh();
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.ShowDialog();
        }

        private void NoneBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (NoneBox2.Checked)
            {
                NewAddress.Enabled = false;
            }
            if (!NoneBox2.Checked)
            {
                NewAddress.Enabled = true;
            }
        }

        private void NoneBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (NoneBox1.Checked)
            {
                NewIP.Enabled = false;
            }
            if (!NoneBox1.Checked)
            {
                NewIP.Enabled = true;
            }
        }
        public bool IsValidIP(string ip)
        {
            if (String.IsNullOrEmpty(ip))
            {
                return false;
            }

            // Split the IP address into its octets
            string[] octets = ip.Split('.');

            // Check if there are exactly 4 octets
            if (octets.Length != 4)
            {
                return false;
            }

            // Check if each octet is a valid integer between 0 and 255
            for (int i = 0; i < octets.Length; i++)
            {
                int octet;
                if (!int.TryParse(octets[i], out octet) || octet < 0 || octet > 255)
                {
                    return false;
                }
            }

            return true;
        }

        private void NewVirtualRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!NewPhsyicalRadioButton.Checked && !NewVirtualRadioButton.Checked)
            {
                CreateNewButton.Enabled = false;
            }
            if (NewVirtualRadioButton.Checked || NewPhsyicalRadioButton.Checked)
            {
                CreateNewButton.Enabled = true;
            }
        }

        private void NewPhsyicalRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!NewPhsyicalRadioButton.Checked && !NewVirtualRadioButton.Checked)
            {
                CreateNewButton.Enabled = false;
            }
            if (NewVirtualRadioButton.Checked || NewPhsyicalRadioButton.Checked)
            {
                CreateNewButton.Enabled = true;
            }
        }
    }

}
