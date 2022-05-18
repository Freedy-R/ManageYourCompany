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
        MySqlConnection connection = new MySqlConnection("Server=sql11.freemysqlhosting.net;User=sql11493326;Database=sql11493326;Password=Z4ByNssQ9K;");
        bool polaczony = false;
        private int wybrano;
        string pochodzenie;
        public fPracownicy(int wybrano)
        {
            this.wybrano = wybrano;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT * FROM pracownicy WHERE ID_obiektu ="+wybrano);
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
            if (txtName.Text == "* Imie")
            {
                txtName.Clear();
                txtName.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Name_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Text = "* Imie";
                txtName.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname_Clear(object sender, EventArgs e)
        {
            if (txtSur.Text == "* Nazwisko")
            {
                txtSur.Clear();
                txtSur.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSur.Text))
            {
                txtSur.Text = "* Nazwisko";
                txtSur.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City_Clear(object sender, EventArgs e)
        {
            if (txtCity.Text == "* Miasto")
            {
                txtCity.Clear();
                txtCity.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                txtCity.Text = "* Miasto";
                txtCity.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address_Clear(object sender, EventArgs e)
        {
            if (txtAddress.Text == "* Adres")
            {
                txtAddress.Clear();
                txtAddress.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.Text = "* Adres";
                txtAddress.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Zipcode_Clear(object sender, EventArgs e)
        {
            if (txtZipcode.Text == "* Kod pocztowy")
            {
                txtZipcode.Clear();
                txtZipcode.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Zipcode_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtZipcode.Text))
            {
                txtZipcode.Text = "* Kod pocztowy";
                txtZipcode.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Born_Clear(object sender, EventArgs e)
        {
            if (txtBorn.Text == "* Data urodzenia")
            {
                txtBorn.Clear();
                txtBorn.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Born_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBorn.Text))
            {
                txtBorn.Text = "* Data urodzenia";
                txtBorn.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country_Clear(object sender, EventArgs e)
        {
            if (txtCountry.Text == "* Kraj urodzenia")
            {
                txtCountry.Clear();
                txtCountry.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                txtCountry.Text = "* Kraj urodzenia";
                txtCountry.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }


        private void Email_Clear(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
                txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Email_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone_Clear(object sender, EventArgs e)
        {
            if (txtPhone.Text == "* Numer kontaktowy")
            {
                txtPhone.Clear();
                txtPhone.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.Text = "* Numer kontaktowy";
                txtPhone.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment_Clear(object sender, EventArgs e)
        {
            if (txtEmplacement.Text == "Stanowisko")
            {
                txtEmplacement.Clear();
                txtEmplacement.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmplacement.Text))
            {
                txtEmplacement.Text = "Stanowisko";
                txtEmplacement.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID_Clear(object sender, EventArgs e)
        {
            if (txtID.Text == "* Pesel")
            {
                txtID.Clear();
                txtID.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Text = "* Pesel";
                txtID.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
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

        private void mastxtKodPocztowyP_Clear(object sender, EventArgs e)
        {
            if (mastxtKodPocztowyP.Text == "* Kod pocztowy")
            {
                mastxtKodPocztowyP.Clear();
                mastxtKodPocztowyP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void mastxtKodPocztowyP_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mastxtKodPocztowyP.Text))
            {
                mastxtKodPocztowyP.Text = "* Kod pocztowy";
                mastxtKodPocztowyP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Born2_Clear(object sender, EventArgs e)
        {
            if (txtDataUroP.Text == "* Data urodzenia")
            {
                txtDataUroP.Clear();
                txtDataUroP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Born2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDataUroP.Text))
            {
                txtDataUroP.Text = "* Data urodzenia";
                txtDataUroP.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
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
            MySqlCommand dodanie = new MySqlCommand("INSERT INTO pracownicy (ID_obiektu, Imie, Nazwisko, Adres, Plec, Kod_Pocztowy, Data_Urodzenia, Kraj_Urodzenia, `E-mail`, Numer_Kontaktowy, Stanowisko, Pesel, Pochodzenie) Values('"+wybrano+"', '"+txtImieP.Text+"','"+txtNazwiskoP.Text+"','"+txtAdresP.Text+"','"+listboxPlecP.Items+"','"+ mastxtKodPocztowyP.Text+"','"+ DateTime.Parse(txtDataUroP.Text)+"','"+txtKrajP.Text+"','"+txtEmail.Text+"','"+txtNumerP.Text+"','"+txtStanowiskoP.Text+"','"+txtPeselP.Text+"','"+pochodzenie+ "'); UPDATE obiekty SET Liczba_pracownikow = Liczba_pracownikow+1 WHERE (SELECT COUNT(*) FROM pracownicy WHERE pracownicy.ID_obiektu = "+wybrano+") > Liczba_pracownikow", connection);
            if (string.IsNullOrEmpty(txtImieP.Text) || string.IsNullOrEmpty(txtNazwiskoP.Text) || string.IsNullOrEmpty(txtAdresP.Text) || string.IsNullOrEmpty(listboxPlecP.Items.ToString()) || string.IsNullOrEmpty(mastxtKodPocztowyP.Text) || string.IsNullOrEmpty(txtDataUroP.Text) || string.IsNullOrEmpty(txtKrajP.Text) || string.IsNullOrEmpty(txtNumerP.Text) || string.IsNullOrEmpty(txtPeselP.Text) || pochodzenie == "")
            {
                MessageBox.Show("nie wypełniłeś wszystkich wymaganych pól. Wypełnij je.");
            }
            else
            {
                tworzenie_pol();
                dodanie.ExecuteNonQuery();
                niszczenie_pol();
                MessageBox.Show("Pracownik został dodany do bazy.");
            }
        }
    }
}
