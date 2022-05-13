using MySql.Data.MySqlClient;
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
        MySqlConnection connection = new MySqlConnection("server = localhost; user=root;database=sklep;port=3306;password=");
        bool polaczony = false;
        int wybrano = 0;
        private int index;

        public fMenu()
        {
            InitializeComponent();
        }
        public void tworzenie_pol()
        {
            if (polaczony == false)
            {
                connection.Open();
                polaczony = true;
            }
        }
        public void niszczenie_pol()
        {
            if (polaczony == true)
            {
                connection.Close();
                polaczony = false;
            }
        }
        public void ladowanie_bazy(string qu)
        {
            this.dgvObiekty.DataSource = null;
            this.dgvObiekty.Rows.Clear();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(qu, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvObiekty.DataSource = ds.Tables[0];
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show("Wychodzi na to że masz błąd:\n " + e);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabObiekty_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("Select * From obiekty");
        }

        private void dgvObiekty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                index = e.RowIndex;
                DataGridViewRow wybrane = dgvObiekty.Rows[index];
                if (wybrane.Cells[0].Value is System.DBNull || wybrane.Cells[0].Value is 0)
                {
                    MessageBox.Show("Błąd wybierz inne");
                }
                else
                {
                    wybrano = Convert.ToInt32(wybrane.Cells[0].Value);
                    MessageBox.Show("Wybrałeś obiekt z ID: " + wybrano);
                }
                rtxtWybrano.Text = "Wybrałeś obiekt z ID: " + wybrano.ToString();
            }
            
            
            

        }

        private void dgvObiekty_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            
        }

        private void dgvObiekty_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvObiekty_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dgvObiekty_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
