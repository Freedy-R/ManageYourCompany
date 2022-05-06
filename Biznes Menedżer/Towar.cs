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
    public partial class fTowar : Form
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; user=root;database=sklep;port=3306;password=");
        bool polaczony = false;
        int wybrano = 0;
        public fTowar()
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
            this.dgvPrzegladaj.DataSource = null;
            this.dgvPrzegladaj.Rows.Clear();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(qu, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvPrzegladaj.DataSource = ds.Tables[0];
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show("Wychodzi na to że masz błąd:\n " + e);
            }
        }

        private void dgvPrzegladaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT * FROM towar");
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            string szukam = txtSzukam.Text;
            string qwSzukam = "SELECT * FROM `towar` WHERE `ID` LIKE '%"+szukam+ "%' OR `ID_obiektu` LIKE '%" + szukam + "%' OR `Nazwa` LIKE '%" + szukam + "%' OR `Ilość` LIKE '%" + szukam + "%' OR `Producent` LIKE '%" + szukam + "%' OR `Nr.Faktury` LIKE '%" + szukam + "%' OR `Podatki_ %` LIKE '%" + szukam + "%' OR `Cena_Netto` LIKE '%" + szukam + "%' OR `Cena_Brutto` LIKE '%" + szukam + "%' OR `Stan` LIKE '%" + szukam + "%'";
            ladowanie_bazy(qwSzukam);
        }
    }
}
