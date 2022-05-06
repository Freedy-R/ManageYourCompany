using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biznes_Menedżer
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        public void DisplayForm(object Form)
        {
            if(this.showWindows.Controls.Count > 0)
                this.showWindows.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.showWindows.Controls.Add(f);
            this.showWindows.Tag = f;
            f.Show();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            DisplayForm(new fPracownicy());
        }

        private void btnMagazine_Click(object sender, EventArgs e)
        {
            DisplayForm(new fTowar());
        }

    }
}
