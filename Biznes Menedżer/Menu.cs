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
        MySqlConnection connection = new MySqlConnection("Server=sql11.freemysqlhosting.net;User=sql11493326;Database=sql11493326;Password=Z4ByNssQ9K;");
        bool polaczony = false;
        int wybrano = 0;
        private int index;
        string adres, nazwaObiektu, kodP, miejscowosc, telefon, adresd, nazwaObiektud, kodPd, miejscowoscd, telefond, liczbaPracownikowd;

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
                MessageBox.Show("Wychodzi na to że masz błąd sprawdź połączenie internetowe lub zbyt duży ruch na serwerze odśwież karte (wyjdź wejdź)");
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
            if(wybrano == 0)
            {
                MessageBox.Show("Nie wybrałeś obiektu, przejdź do zakładki obiekty i wybierz (Dwukrotne klikniecie na obiekt).");
            }
            else
            {
                DisplayForm(new fPracownicy(wybrano));
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (wybrano == 0)
            {
                MessageBox.Show("Nie wybrałeś obiektu, przejdź do zakładki obiekty i wybierz (Dwukrotne klikniecie na obiekt).");
            }
            else
            {
                tworzenie_pol();
                MySqlCommand usuwanie = new MySqlCommand("DELETE FROM obiekty WHERE ID ="+wybrano+ "; DELETE FROM towar  WHERE ID_obiektu =" + wybrano+ "; DELETE FROM pracownicy  WHERE ID_obiektu =" + wybrano, connection);
                usuwanie.ExecuteNonQuery();
                niszczenie_pol();
                MessageBox.Show("Usunięcie Udane");

            }
            ladowanie_bazy("Select * From obiekty");

        }

        private void btnMagazine_Click(object sender, EventArgs e)
        {
            if (wybrano==0)
            {
                MessageBox.Show("Nie wybrałeś obiektu, przejdź do zakładki obiekty i wybierz (Dwukrotne klikniecie na obiekt).");
            }
            else {
                DisplayForm(new fTowar(wybrano));
            }
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
                adres= wybrane.Cells[2].Value.ToString();
                nazwaObiektu = wybrane.Cells[1].Value.ToString();
                kodP = wybrane.Cells[3].Value.ToString();
                miejscowosc = wybrane.Cells[4].Value.ToString();
                telefon = wybrane.Cells[5].Value.ToString();
                if (wybrane.Cells[0].Value is System.DBNull || wybrane.Cells[0].Value is 0)
                {
                    MessageBox.Show("Błąd wybierz inne");
                }
                else
                {
                    wybrano = Convert.ToInt32(wybrane.Cells[0].Value);
                    
                    MessageBox.Show("Wybrałeś obiekt z ID: " + wybrano);
                }
                rtxtWybrano.Text = "Wybrałeś Obiekt z ID: " + wybrano.ToString();
                
            }
            
            
            

        }

        private void dgvObiekty_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            
        }

        private void btnADD_Click(object sender, EventArgs e){


            
            DataGridViewRow wybrane = dgvObiekty.Rows[this.index];
            adresd = wybrane.Cells[2].Value.ToString();
            nazwaObiektud = wybrane.Cells[1].Value.ToString();
            kodPd = wybrane.Cells[3].Value.ToString();
            miejscowoscd = wybrane.Cells[4].Value.ToString();
            telefond = wybrane.Cells[5].Value.ToString();
            liczbaPracownikowd = wybrane.Cells[6].Value.ToString();
            MySqlCommand dodawanie = new MySqlCommand("INSERT INTO obiekty(Nazwa_obiektu, Adres, Kod_Pocztowy, Miejscowosc, Telefon, Liczba_pracownikow) VALUES('"+nazwaObiektud+"', '"+adresd+"', '"+kodPd+"', '"+miejscowoscd+"', '"+telefond+"', '"+liczbaPracownikowd+"')", connection);
            if (string.IsNullOrEmpty(nazwaObiektud) || string.IsNullOrEmpty(adresd) || string.IsNullOrEmpty(kodPd) || string.IsNullOrEmpty(miejscowoscd) || string.IsNullOrEmpty(telefond) || string.IsNullOrEmpty(liczbaPracownikowd))
            {
                MessageBox.Show("Nie uzypełniłeś wszystkich pól (prócz ID)");
            }
            else
            {
                tworzenie_pol();
                dodawanie.ExecuteNonQuery();
                niszczenie_pol();
                MessageBox.Show("Udało ci się dodać dane do bazy danych.");
                
            }
            ladowanie_bazy("Select * From obiekty");

        }

        private void dgvObiekty_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            this.index = index;
        }

        private void dgvObiekty_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dgvObiekty_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (wybrano == 0)
            {
                MessageBox.Show("Nie wybrałeś obiektu, przejdź do zakładki obiekty i wybierz (Dwukrotne klikniecie na obiekt).");
            }
            else
            {
                modyfikuj_obiekt form = new modyfikuj_obiekt(wybrano,adres,nazwaObiektu,kodP,miejscowosc,telefon);
                form.Show();
                this.Hide();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }
    }
    }

