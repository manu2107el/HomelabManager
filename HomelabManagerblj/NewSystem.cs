using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomelabManagerblj
{
    public partial class NewSystem : Form
    {
        List<Physical> NewPhysical;
        List<Virtual> NewVirtual;
        private Overview overview = (Overview)Application.OpenForms["Overview"];
        Physical Mother;
       
        
        public NewSystem(List<Physical> PhysicalsFromMain, List<Virtual> VirtualsFromMain)
        {
            InitializeComponent();
            this.NewPhysical = PhysicalsFromMain;
            this.NewVirtual = VirtualsFromMain;
        }
        private void MotherSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NewTestButton_Click(object sender, EventArgs e)
        {
            MotherSelector.Items.Clear();
            foreach (Physical system in NewPhysical)
            {
                MotherSelector.Items.Add(system.Name.ToString());
            }
            MessageBox.Show("TEST RUN");
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
                    if(string.IsNullOrEmpty(NewAddress.Text) == false)
                    {
                        newPortal = NewAddress.Text;
                        newPortalSet |= true;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter an address");
                    }
                }
                if(newIPSet && newNameSet && newPortalSet)
                { 
                    Physical system = new Physical();
                    system.Name = newName;
                    system.IP = newIP;
                    system.Portal = newPortal;
                    system.IgnorePortal = ignorePortal;
                    system.IgnoreIP = ignoreIP;
                    NewPhysical.Add(system);
                    newName = "";
                    newIP = "";
                    newPortal = "";
                    newNameSet = false;
                    newIPSet = false;
                    newPortalSet = false;
                    ignorePortal = false;
                    ignoreIP = false;
                }
            }
            if (NewVirtualRadioButton.Checked)
            {
                Mother = MotherSelector.SelectedItem as Physical;
                MessageBox.Show(Convert.ToString(Mother.IP));
                
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
                    NewPhysical.Add(system);
                    newName = "";
                    newIP = "";
                    newPortal = "";
                    newNameSet = false;
                    newIPSet = false;
                    newPortalSet = false;
                    ignorePortal = false;
                    ignoreIP = false;
                }
            }



            MotherSelector.Items.Clear();
            foreach (Physical systemList in NewPhysical)
            {
                MotherSelector.Items.Add(systemList);
            }
            MessageBox.Show("CREATE RUN");
        }
        

        private void NewSystem_Load(object sender, EventArgs e)
        {
            SendToMainBar.Visible = false;
            NewPhsyicalRadioButton.Checked = true;
            
            
            MotherSelector.Items.Clear();
            foreach (Physical system in NewPhysical)
            {
                MotherSelector.Items.Add(system.Name.ToString());
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
        private void NewCloseButton_Click(object sender, EventArgs e)
        {
            SendToMainBar.Visible = true;
            Application.DoEvents();
            overview.UpdateLists(NewPhysical, NewVirtual);
            SendToMainBar.Value = 100;
            Application.DoEvents();
            Thread.Sleep(1000);
            this.Close();
        }

    }
}
