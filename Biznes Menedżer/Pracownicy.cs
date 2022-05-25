using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biznes_Menedżer
{
    public partial class fPracownicy : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=mysql8001.site4now.net;User=a877f4_sklepik;Database=db_a877f4_sklepik;Password=kamilos04;");// W przypadku braku połączenia i problemów za komentarzować i odkomentarzować poniższy
        //MySqlConnection connection = new MySqlConnection("Server=localhost;User=root;Database=sklep;Password=;"); //Pamiętaj by stworzyć za pomocą xamppa bazę sklep i zaimportować z folderu baza danych
        bool polaczony = false;
        private int wybranoO, index, wybranoP, indexUsun;
        string pochodzenie, pochodzenieM, imiep, nazwiskop, miastop, adresp, kodp, plecp, krajp, emailp, numerp, stanowiskop, peselp, pochodzeniep;
        DateTime dataUrop;
        public fPracownicy(int wybrano)
        {
            this.wybranoO = wybrano;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void tworzenie_pol()
        {
            if (polaczony == false)
            {
                try
                {
                    connection.Open();
                    polaczony = true;
                }catch(MySql.Data.MySqlClient.MySqlException )
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
        public void czyszczeniem()
        {
            txtPeselPM.Text = "* Pesel";
            txtPeselPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtStanowiskoPM.Text = "Stanowisko";
            txtStanowiskoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtNumerPM.Text = "* Numer kontaktowy";
            txtNumerPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtEmailPM.Text = "Email";
            txtEmailPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtKrajUroPM.Text = "* Kraj urodzenia";
            txtKrajUroPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtAdresPM.Text = "* Adres";
            txtAdresPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtMiastoPM.Text = "* Miasto";
            txtMiastoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtNazwiskoPM.Text = "* Nazwisko";
            txtNazwiskoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtImiePM.Text = "* Imie";
            txtImiePM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
        }
        public void czyszczenie()
        {
            txtPeselP.Text = "* Pesel";
            txtPeselP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtStanowiskoP.Text = "Stanowisko";
            txtStanowiskoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtNumerP.Text = "* Numer kontaktowy";
            txtNumerP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtEmailP.Text = "Email";
            txtEmailP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtKrajP.Text = "* Kraj urodzenia";
            txtKrajP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtAdresP.Text = "* Adres";
            txtAdresP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtMiastoP.Text = "* Miasto";
            txtMiastoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtNazwiskoP.Text = "* Nazwisko";
            txtNazwiskoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            txtImieP.Text = "* Imie";
            txtImieP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
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
            catch (MySql.Data.MySqlClient.MySqlException )
            {
                MessageBox.Show("Wychodzi na to że masz błąd sprawdź połączenie internetowe. I załaduj okienko jeszcze raz");
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT ID, Imie, Nazwisko, Miasto, Adres, Plec, Kod_Pocztowy, Data_Urodzenia, `E-mail`, Numer_Kontaktowy, Stanowisko, Pesel, Pochodzenie FROM pracownicy WHERE ID_obiektu ="+wybranoO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szukam = txtSzukam.Text;
            tworzenie_pol();
            var qwszukanie = "SELECT * FROM `pracownicy` WHERE `ID` LIKE '%"+szukam+ "%' OR `ID_obiektu` LIKE '%" + szukam + "%' OR `Imie` LIKE '%" + szukam + "%' OR `Nazwisko` LIKE '%" + szukam + "%' OR `Miasto` LIKE '%" + szukam + "%' OR `Adres` LIKE '%" + szukam + "%' OR `Płeć` LIKE '%" + szukam + "%' OR `Kod_Pocztowy` LIKE '%" + szukam + "%' OR `Data_Urodzenia` LIKE '%" + szukam + "%' OR `Kraj_Urodzenia` LIKE '%" + szukam + "%' OR `E-mail` LIKE '%" + szukam + "%' OR `Numer_Kontaktowy` LIKE '%" + szukam + "%' OR `Stanowisko` LIKE '%" + szukam + "%' OR `Pesel` LIKE '%" + szukam + "%' OR `Pochodzenie` LIKE '%" + szukam + "%'";
            if (szukam != "")
                ladowanie_bazy(qwszukanie);
        }

        private void Name_Clear(object sender, EventArgs e)
        {
            if (txtImiePM.Text == "* Imie")
            {
                txtImiePM.Clear();
                txtImiePM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Name_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImiePM.Text))
            {
                txtImiePM.Text = "* Imie";
                txtImiePM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname_Clear(object sender, EventArgs e)
        {
            if (txtNazwiskoPM.Text == "* Nazwisko")
            {
                txtNazwiskoPM.Clear();
                txtNazwiskoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazwiskoPM.Text))
            {
                txtNazwiskoPM.Text = "* Nazwisko";
                txtNazwiskoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City_Clear(object sender, EventArgs e)
        {
            if (txtMiastoPM.Text == "* Miasto")
            {
                txtMiastoPM.Clear();
                txtMiastoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMiastoPM.Text))
            {
                txtMiastoPM.Text = "* Miasto";
                txtMiastoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address_Clear(object sender, EventArgs e)
        {
            if (txtAdresPM.Text == "* Adres")
            {
                txtAdresPM.Clear();
                txtAdresPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresPM.Text))
            {
                txtAdresPM.Text = "* Adres";
                txtAdresPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }
        private void Country_Clear(object sender, EventArgs e)
        {
            if (txtKrajUroPM.Text == "* Kraj urodzenia")
            {
                txtKrajUroPM.Clear();
                txtKrajUroPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKrajUroPM.Text))
            {
                txtKrajUroPM.Text = "* Kraj urodzenia";
                txtKrajUroPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }


        private void Email_Clear(object sender, EventArgs e)
        {
            if (txtEmailPM.Text == "Email")
            {
                txtEmailPM.Clear();
                txtEmailPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Email_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailPM.Text))
            {
                txtEmailPM.Text = "Email";
                txtEmailPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone_Clear(object sender, EventArgs e)
        {
            if (txtNumerPM.Text == "* Numer kontaktowy")
            {
                txtNumerPM.Clear();
                txtNumerPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumerPM.Text))
            {
                txtNumerPM.Text = "* Numer kontaktowy";
                txtNumerPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment_Clear(object sender, EventArgs e)
        {
            if (txtStanowiskoPM.Text == "Stanowisko")
            {
                txtStanowiskoPM.Clear();
                txtStanowiskoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStanowiskoPM.Text))
            {
                txtStanowiskoPM.Text = "Stanowisko";
                txtStanowiskoPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID_Clear(object sender, EventArgs e)
        {
            if (txtPeselPM.Text == "* Pesel")
            {
                txtPeselPM.Clear();
                txtPeselPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeselPM.Text))
            {
                txtPeselPM.Text = "* Pesel";
                txtPeselPM.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }




        private void Name2_Clear(object sender, EventArgs e)
        {
            if (txtImieP.Text == "* Imie")
            {
                txtImieP.Clear();
                txtImieP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Name2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImieP.Text))
            {
                txtImieP.Text = "* Imie";
                txtImieP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname2_Clear(object sender, EventArgs e)
        {
            if (txtNazwiskoP.Text == "* Nazwisko")
            {
                txtNazwiskoP.Clear();
                txtNazwiskoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazwiskoP.Text))
            {
                txtNazwiskoP.Text = "* Nazwisko";
                txtNazwiskoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City2_Clear(object sender, EventArgs e)
        {
            if (txtMiastoP.Text == "* Miasto")
            {
                txtMiastoP.Clear();
                txtMiastoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMiastoP.Text))
            {
                txtMiastoP.Text = "* Miasto";
                txtMiastoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address2_Clear(object sender, EventArgs e)
        {
            if (txtAdresP.Text == "* Adres")
            {
                txtAdresP.Clear();
                txtAdresP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresP.Text))
            {
                txtAdresP.Text = "* Adres";
                txtAdresP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country2_Clear(object sender, EventArgs e)
        {
            if (txtKrajP.Text == "* Kraj urodzenia")
            {
                txtKrajP.Clear();
                txtKrajP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKrajP.Text))
            {
                txtKrajP.Text = "* Kraj urodzenia";
                txtKrajP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }


        private void Email2_Clear(object sender, EventArgs e)
        {
            if (txtEmailP.Text == "Email")
            {
                txtEmailP.Clear();
                txtEmailP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Email2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailP.Text))
            {
                txtEmailP.Text = "Email";
                txtEmailP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone2_Clear(object sender, EventArgs e)
        {
            if (txtNumerP.Text == "* Numer kontaktowy")
            {
                txtNumerP.Clear();
                txtNumerP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumerP.Text))
            {
                txtNumerP.Text = "* Numer kontaktowy";
                txtNumerP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            wybranoP = 0;
        }

        private void Employment2_Clear(object sender, EventArgs e)
        {
            if (txtStanowiskoP.Text == "Stanowisko")
            {
                txtStanowiskoP.Clear();
                txtStanowiskoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStanowiskoP.Text))
            {
                txtStanowiskoP.Text = "Stanowisko";
                txtStanowiskoP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID2_Clear(object sender, EventArgs e)
        {
            if (txtPeselP.Text == "* Pesel")
            {
                txtPeselP.Clear();
                txtPeselP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeselP.Text))
            {
                txtPeselP.Text = "* Pesel";
                txtPeselP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            tworzenie_pol();
            if (radioObywatelstwoPol.Checked == true)
            {
                pochodzenie = "Polskie";
            }
            else if (radioObywatelstwoCudz.Checked == true)
            {
                pochodzenie = "Cudzoziemskie";
            }
            MySqlCommand dodanie = new MySqlCommand("INSERT INTO pracownicy (ID_obiektu, Imie, Nazwisko, Miasto, Adres, Plec, Kod_Pocztowy, Data_Urodzenia, Kraj_Urodzenia, `E-mail`, Numer_Kontaktowy, Stanowisko, Pesel, Pochodzenie) " +
                "Values('"+wybranoO+"', '"+txtImieP.Text+"','"+txtNazwiskoP.Text+"','"+txtMiastoP.Text+"','" + txtAdresP.Text+"','"+ listboxPlecP.GetItemText(listboxPlecP.SelectedItem) + "','"+ mastxtKodPocztowyP.Text+"','"+ txtDataUroP.Value.Date.ToString("yyyy-MM-dd")+ "','"+txtKrajP.Text+"','"+txtEmailPM.Text+"','"+txtNumerP.Text+"','"+txtStanowiskoP.Text+"','"+txtPeselP.Text+"','"+pochodzenie+ "');" +
                " UPDATE obiekty SET Liczba_pracownikow = Liczba_pracownikow+1 WHERE (SELECT COUNT(*) FROM pracownicy WHERE pracownicy.ID_obiektu = "+wybranoO+") > Liczba_pracownikow", connection);
            if (string.IsNullOrEmpty(txtImieP.Text) || string.IsNullOrEmpty(txtNazwiskoP.Text) || string.IsNullOrEmpty(txtAdresP.Text) || listboxPlecP.GetItemText(listboxPlecP.SelectedItem) != "Mężczyzna" || listboxPlecP.GetItemText(listboxPlecP.SelectedItem) != "Kobieta" || string.IsNullOrEmpty(mastxtKodPocztowyP.Text) || string.IsNullOrEmpty(txtDataUroP.Text) || string.IsNullOrEmpty(txtKrajP.Text) || string.IsNullOrEmpty(txtNumerP.Text) || string.IsNullOrEmpty(txtPeselP.Text) || pochodzenie == "")
            {
                MessageBox.Show("nie wypełniłeś wszystkich wymaganych pól. Wypełnij je.");
            }
            else
            {
                tworzenie_pol();
                dodanie.ExecuteNonQuery();
                niszczenie_pol();
                MessageBox.Show("Pracownik został dodany do bazy.");
                czyszczenie();
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            if(wybranoP == 0)
            {
                MessageBox.Show("Nie wybrałeś Pracownika do modyfikowania lub jest nie zaktualizowany przejdź do zakładki przeglądaj i wybierz go. (Dwukrotne klikniecie na jakiegos)");
            }
            else
            {

                txtPeselPM.Text = peselp;
                txtStanowiskoPM.Text = stanowiskop;
                txtNumerPM.Text = numerp;
                txtEmailPM.Text = emailp;
                txtKrajUroPM.Text = krajp;
                txtAdresPM.Text = adresp;
                txtMiastoPM.Text = miastop;
                txtNazwiskoPM.Text = nazwiskop;
                txtImiePM.Text = imiep;
                txtKodPocztowyPM.Text = kodp;
                txtDataUroPM.Text = dataUrop.ToString();
                if(pochodzeniep == "Polskie")
                {
                    radioObywatelstwoPolM.Checked = true;
                    radioObywatelstwoCudzM.Checked = false;
                }
                else if(pochodzeniep == "Cudzoziemskie")
                {
                    radioObywatelstwoCudzM.Checked = true;
                    radioObywatelstwoPolM.Checked = false;
                }
                if(plecp == "Mężczyzna")
                {
                    listboxPlecPM.SelectedIndex = 0;
                }else if(plecp == "Kobieta")
                {
                    listboxPlecPM.SelectedIndex = 1;
                }
            }
        }

        private void dgvPrzegladaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexUsun = e.RowIndex;
        }

        private void dgvPrzegladaj_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            
            
        }

        private void dgvPrzegladaj_Enter(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT ID, Imie, Nazwisko, Miasto, Adres, Plec, Kod_Pocztowy, Data_Urodzenia, `E-mail`, Numer_Kontaktowy, Stanowisko, Pesel, Pochodzenie FROM pracownicy WHERE ID_obiektu =" + wybranoO);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {

            czyszczenie();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            czyszczenie();
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
                        DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien że chcesz usunąć pracownika z ID: " + wybrane.Cells[0].Value.ToString(), "Usuwanie", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            tworzenie_pol();
                            MySqlCommand usun = new MySqlCommand("DELETE FROM pracownicy WHERE ID = " + wybrane.Cells[0].Value+ ";" +
                                " UPDATE obiekty SET Liczba_pracownikow = Liczba_pracownikow-1 WHERE (SELECT COUNT(*) FROM pracownicy WHERE pracownicy.ID_obiektu = " + wybranoO + ") <= Liczba_pracownikow", connection);
                            usun.ExecuteNonQuery();
                            MessageBox.Show("Usunięto");
                            niszczenie_pol();
                            ladowanie_bazy("SELECT ID, Imie, Nazwisko, Miasto, Adres, Plec, Kod_Pocztowy, Data_Urodzenia, `E-mail`, Numer_Kontaktowy, Stanowisko, Pesel, Pochodzenie FROM pracownicy WHERE ID_obiektu =" + wybranoO);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                        }
                    }
                }
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(wybranoP != 0)
            {
                if (radioObywatelstwoPolM.Checked == true)
                {
                    pochodzenieM = "Polskie";
                }
                else if (radioObywatelstwoCudzM.Checked == true)
                {
                    pochodzenieM = "Cudzoziemskie";
                }
                tworzenie_pol();
                if (wybranoP == 0)
                {
                    MessageBox.Show("Nie wybrałeś pracownika, przejdź do zakładki przeglądaj i wybierz (Dwukrotne klikniecie na pracownika).");
                }
                if (wybranoP > 0)
                {
                    MySqlCommand modyfikuj_towar = new MySqlCommand("UPDATE pracownicy SET Imie ='" + txtImiePM.Text + "',Nazwisko='" + txtNazwiskoPM.Text + "',Miasto='" + txtMiastoPM.Text
                        + "',Adres ='" + txtAdresPM.Text + "',Plec= '" + listboxPlecPM.GetItemText(listboxPlecPM.SelectedItem) + "',Kod_Pocztowy='" + txtKodPocztowyPM.Text + "',Data_Urodzenia='" + txtDataUroPM.Value.Date.ToString("yyyy-MM-dd")
                        + "',Kraj_Urodzenia='" + txtKrajUroPM.Text + "',`E-mail`='" + txtEmailPM.Text + "',Numer_Kontaktowy='" + txtNumerPM.Text + "',Stanowisko='" + txtStanowiskoPM.Text + "',Pesel='" + txtPeselPM.Text + "',Pochodzenie='" + pochodzenieM + "' WHERE ID = '" + wybranoP+"'", connection);
                    modyfikuj_towar.ExecuteNonQuery();
                    MessageBox.Show("Zmodyfikowałeś pracownika z ID " + wybranoP);
                    czyszczeniem();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrałeś Pracownika do modyikowania przejdź do zakładki przeglądaj i wybierz go. (Dwukrotne klikniecie na jakiegos)");
            }
        }

        private void listboxPlecP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPrzegladaj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index > -1)
            {

                DataGridViewRow wybrane = dgvPrzegladaj.Rows[index];
                if (wybrane.Cells[0].Value is System.DBNull || wybrane.Cells[0].Value is 0)
                {
                    MessageBox.Show("Błąd wybierz inne");
                }
                else
                {
                    wybranoP = Convert.ToInt32(wybrane.Cells[0].Value);
                    imiep = wybrane.Cells[1].Value.ToString();
                    nazwiskop = wybrane.Cells[2].Value.ToString();
                    miastop = wybrane.Cells[3].Value.ToString();
                    adresp = wybrane.Cells[4].Value.ToString();
                    plecp = wybrane.Cells[5].Value.ToString();
                    kodp = wybrane.Cells[6].Value.ToString();
                    dataUrop = Convert.ToDateTime(wybrane.Cells[7].Value.ToString());
                    krajp = wybrane.Cells[9].Value.ToString();
                    emailp = wybrane.Cells[8].Value.ToString();
                    numerp = wybrane.Cells[9].Value.ToString();
                    stanowiskop = wybrane.Cells[10].Value.ToString();
                    peselp = wybrane.Cells[11].Value.ToString();
                    pochodzeniep = wybrane.Cells[12].Value.ToString();
                    
                    MessageBox.Show("Wybrałeś Pracownika z ID: " + wybranoP);
                }
            }
        }
    }
}
