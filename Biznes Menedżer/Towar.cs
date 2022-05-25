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
        MySqlConnection connection = new MySqlConnection("Server=sql11.freemysqlhosting.net;User=sql11495118;Database=sql11495118;Password=TmiBWjhEKf;");// W przypadku braku połączenia i problemów za komentarzować i odkomentarzować poniższy
       //MySqlConnection connection = new MySqlConnection("Server=localhost;User=root;Database=sklep;Password=;"); //Pamiętaj by stworzyć za pomocą xamppa bazę sklep i zaimportować z folderu baza danych
        bool polaczony = false;
        private int wybranoO = 0;
        private int wybranoT = 0;
        private int index, indexUsun;
        DataGridViewRow wybrane;
        string nazwa, ilosc, producent, nr_faktury, podatek, cenaNetto, cenaBrutto, stan;
        public fTowar(int wybrano)
        {

            this.wybranoO = wybrano;
            InitializeComponent();
        }
        public void tworzenie_pol()
        {
            if (polaczony == false)
            {
                try
                {
                    connection.Open();
                    polaczony = true;
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Wychodzi na to że masz błąd sprawdź połączenie internetowe lub zbyt duży ruch na serwerze. ");
                }
            }
        }
        public void niszczenie_pol()
        {
            if (polaczony == true)
            {
                try
                {
                    connection.Close();
                    polaczony = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Wychodzi na to że masz błąd sprawdź połączenie internetowe lub zbyt duży ruch na serwerze. ");
                }
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

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT * FROM towar WHERE ID_obiektu =" + wybranoO);
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            string szukam = txtSzukam.Text;
            string qwSzukam = "SELECT * FROM `towar` WHERE `ID` LIKE '%" + szukam + "%' OR `ID_obiektu` LIKE '%" + szukam + "%' OR `Nazwa` LIKE '%" + szukam + "%' OR `Ilość` LIKE '%" + szukam + "%' OR `Producent` LIKE '%" + szukam + "%' OR `Nr_Faktury` LIKE '%" + szukam + "%' OR `Podatki` LIKE '%" + szukam + "%' OR `Cena_Netto` LIKE '%" + szukam + "%' OR `Cena_Brutto` LIKE '%" + szukam + "%' OR `Stan` LIKE '%" + szukam + "%'";
            ladowanie_bazy(qwSzukam);
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

        private void dgvPrzegladaj_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (indexUsun > -1)
            {

                DataGridViewRow wybrane = dgvPrzegladaj.Rows[indexUsun];
                if (wybrane.Cells[0].Value is System.DBNull || wybrane.Cells[0].Value is 0)
                {
                    MessageBox.Show("Błąd wybierz inne");
                }
                else
                {
                    if (e.KeyCode == Keys.D)
                    {
                        DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien że chcesz usunąć Towar z ID: " + wybrane.Cells[0].Value.ToString(), "Usuwanie", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            tworzenie_pol();
                            MySqlCommand usun = new MySqlCommand("DELETE FROM towar WHERE ID = " + wybrane.Cells[0].Value + ";", connection);
                            usun.ExecuteNonQuery();
                            MessageBox.Show("Usunięto");
                            niszczenie_pol();
                            ladowanie_bazy("SELECT * FROM towar WHERE ID_obiektu =" + wybranoO);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                        }
                    }
                }
            }
        }

        private void dgvPrzegladaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maxIlosc, idTowaru, podatekTowaru;
            decimal cenaNettoTowaru, cenaBruttoTowaru;
            string nazwaTowaru, producentTowaru, nr_fakturyTowaru,stanTowaru;
            indexUsun = e.RowIndex;
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                DataGridViewRow wybrane = dgvPrzegladaj.Rows[index];
                if (wybrane.Cells[0].Value is System.DBNull || Convert.ToInt32(wybrane.Cells[0].Value) == 0)
                {
                    MessageBox.Show("Wybrałeś nie prawidłowo ");
                }
                else if(dgvPrzegladaj.CurrentCell.ColumnIndex.Equals(9) && (wybrane.Cells[0].Value is System.DBNull) == false)
                {

                    idTowaru = Convert.ToInt32(wybrane.Cells[0].Value);
                    nazwaTowaru = wybrane.Cells[2].Value.ToString();
                    maxIlosc = Convert.ToInt32(wybrane.Cells[3].Value);
                    producentTowaru = wybrane.Cells[4].Value.ToString();
                    nr_fakturyTowaru = wybrane.Cells[5].Value.ToString();
                    podatekTowaru = Convert.ToInt32(wybrane.Cells[6].Value.ToString());
                    cenaNettoTowaru = Convert.ToDecimal(wybrane.Cells[7].Value);
                    cenaBruttoTowaru = Convert.ToDecimal(wybrane.Cells[8].Value);
                    stanTowaru = wybrane.Cells[9].Value.ToString();
                    fStan stan = new fStan(wybranoO, maxIlosc, idTowaru, nazwaTowaru, producentTowaru, nr_fakturyTowaru, podatekTowaru, cenaNettoTowaru, cenaBruttoTowaru, stanTowaru);
                    this.Enabled = false;
                    stan.Show();
                    stan.Closed += (s, args) => this.Close();
                    stan.Show();
                    stan.Activate();
                }
            }
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


        private void dgvPrzegladaj_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        private void dgvPrzegladaj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                wybrane = dgvPrzegladaj.Rows[index];
                if (wybrane.Cells[0].Value is System.DBNull || wybrane.Cells[0].Value is 0)
                {
                    MessageBox.Show("Błąd wybierz inne");
                }
                else
                {
                    wybranoT = Convert.ToInt32(wybrane.Cells[0].Value);
                    MessageBox.Show("Wybrałeś obiekt z ID: " + wybranoT);
                }
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            tworzenie_pol();
            MySqlCommand dodanie_towaru = new MySqlCommand("INSERT INTO towar(ID_Obiektu,Nazwa, Ilosc, Producent, Nr_Faktury, Podatki, Cena_Netto, Stan) " +
                "VALUES" + "('" + this.wybranoO + "','" + txtNazwa.Text + "','" + numIlosc.Value + "','" + txtProducent.Text + "','" + txtNrFaktury.Text + "','" + numPodatek.Value + "','" + numCenaNetto.Value + "','" + cbStan.GetItemText(cbStan.SelectedItem) + "')", connection);
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
            if (wybranoT == 0)
            {
                MessageBox.Show("Nie wybrałeś obiektu, przejdź do zakładki przeglądaj i wybierz (Dwukrotne klikniecie na towar).");
            }
            if (wybranoT > 0)
            {
                MySqlCommand modyfikuj_towar = new MySqlCommand("UPDATE towar SET Nazwa ='" + txtNazwaM.Text + "',Ilosc=" + numIloscM.Value + ",Producent='" + txtProducentM.Text 
                    + "',Nr_Faktury='" + txtNr_FakturyM.Text + "',Podatki=" + numPodatekM.Value + ",Cena_Netto=" + numCenaNettoM.Value + ",Cena_Brutto='" + lblWartoscBrutto.Text 
                    + "',Stan='"+ cbStanM.Text+"' WHERE ID ="+wybranoT,connection);
                modyfikuj_towar.ExecuteNonQuery();
                MessageBox.Show("Zmodyfikowałeś towar z ID +" + wybranoT);
            }
            
        }

    }
}
