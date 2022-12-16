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
    public partial class Overview : Form
    {
        List<Physical> PhysicalMain = new List<Physical>();
        List<Virtual> VirtualMain = new List<Virtual>();
        
        public Overview()
        {
            InitializeComponent();
        }

        public void UpdateLists(List<Physical> NewPhysical, List<Virtual> NewVirtual)
        {
            this.PhysicalMain = NewPhysical;
            this.VirtualMain = NewVirtual;
        }
        private void NewSystemButton_Click(object sender, EventArgs e)
        {
            NewSystem newSystem = new NewSystem(PhysicalMain, VirtualMain);
            newSystem.Show();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            

        }
    }
}
