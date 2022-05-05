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
    public partial class fPracownicy : Form
    {
        public fPracownicy()
        {
            InitializeComponent();
        }

        private void fPracownicy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDataDataSet.Pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.businessDataDataSet.Pracownicy);

        }
    }
}
