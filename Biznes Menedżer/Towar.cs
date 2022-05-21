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
        MySqlConnection connection = new MySqlConnection("Server=sql11.freemysqlhosting.net;User=sql11493326;Database=sql11493326;Password=Z4ByNssQ9K;");
        bool polaczony = false;
        private int wybrano;
        public fTowar(int wybrano)
        {

            this.wybrano = wybrano;
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
                MessageBox.Show("Wychodzi na to że masz błąd sprawdź połączenie internetowe.");
            }
        }

        private void dgvPrzegladaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT * FROM towar WHERE ID_obiektu =" + wybrano);
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            string szukam = txtSzukam.Text;
            string qwSzukam = "SELECT * FROM `towar` WHERE `ID` LIKE '%" + szukam + "%' OR `ID_obiektu` LIKE '%" + szukam + "%' OR `Nazwa` LIKE '%" + szukam + "%' OR `Ilość` LIKE '%" + szukam + "%' OR `Producent` LIKE '%" + szukam + "%' OR `Nr_Faktury` LIKE '%" + szukam + "%' OR `Podatki` LIKE '%" + szukam + "%' OR `Cena_Netto` LIKE '%" + szukam + "%' OR `Cena_Brutto` LIKE '%" + szukam + "%' OR `Stan` LIKE '%" + szukam + "%'";
            ladowanie_bazy(qwSzukam);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            tworzenie_pol();
            MySqlCommand dodanie_towaru = new MySqlCommand("INSERT INTO towar(ID_Obiektu,Nazwa, Ilosc, Producent, Nr_Faktury, Podatki, Cena_Netto, Stan) " +
                "VALUES" + "('"+this.wybrano+"','"+ txtNazwa.Text + "','" + numIlosc.Value + "','" + txtProducent.Text + "','" + txtNrFaktury.Text + "','" + numPodatek.Value + "','" + numCenaNetto.Value + "','" + cbStan.GetItemText(cbStan.SelectedItem) + "')", connection);
            if (string.IsNullOrEmpty(txtNazwa.Text) || string.IsNullOrEmpty(numIlosc.Text) || string.IsNullOrEmpty(txtProducent.Text) || string.IsNullOrEmpty(txtNrFaktury.Text) || string.IsNullOrEmpty(numPodatek.Text) || string.IsNullOrEmpty(numCenaNetto.Text) || string.IsNullOrEmpty(cbStan.Text))
            {
                MessageBox.Show("Nie wypełniłeś wszystkich wymaganych pól. Wypełnij je.");
            }
            else
            {
                dodanie_towaru.ExecuteNonQuery();
                niszczenie_pol();
                MessageBox.Show("Towar został dodany do bazy.");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            tworzenie_pol();
            MySqlCommand modyfikuj_towar = new MySqlCommand("ALTER TABLE towar");
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtNazwa.Text = "";
            numIlosc.Text = "";
            txtProducent.Text = "";
            txtNrFaktury.Text = "";
            numPodatek.Text = "";
            numCenaNetto.Text = "";
        }

        private void numCena_ValueChanged(object sender, EventArgs e)
        {

        }
        public void przeliczanie()
        {
            lblWartoscNetto.Text = numCenaNetto.Value.ToString();
            lblKpodatkow.Text = (numCenaNetto.Value * (numPodatek.Value / 100)).ToString();
            lblWartoscBrutto.Text = (numCenaNetto.Value + (numCenaNetto.Value * (numPodatek.Value / 100))).ToString();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            przeliczanie();

        }

        private void numPodatek_ValueChanged(object sender, EventArgs e)
        {
            przeliczanie();
        }

        private void numCenaNetto_ValueChanged(object sender, EventArgs e)
        {
            przeliczanie();
        }

        
    }
}
