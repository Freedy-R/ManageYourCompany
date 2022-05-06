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
    public partial class fTowar : Form
    {
        public fTowar()
        {
            InitializeComponent();
        }

        private void towarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.towarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDataDataSet);

        }

        private void fTowar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDataDataSet.Towar' table. You can move, or remove it, as needed.
            this.towarTableAdapter.Fill(this.businessDataDataSet.Towar);

        }
    }
}
