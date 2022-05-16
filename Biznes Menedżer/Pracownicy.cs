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
        MySqlConnection connection = new MySqlConnection("server = localhost; user=root;database=sklep;port=3306;password=");
        bool polaczony = false;
        int wybrano = 0;
        public fPracownicy()
        {
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
                MessageBox.Show("Wychodzi na to że masz błąd:\n " + e);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ladowanie_bazy("SELECT * FROM pracownicy");
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
            if (txtName2.Text == "* Imie")
            {
                txtName2.Clear();
                txtName2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Name2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName2.Text))
            {
                txtName2.Text = "* Imie";
                txtName2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname2_Clear(object sender, EventArgs e)
        {
            if (txtSur2.Text == "* Nazwisko")
            {
                txtSur2.Clear();
                txtSur2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Surname2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSur2.Text))
            {
                txtSur2.Text = "* Nazwisko";
                txtSur2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City2_Clear(object sender, EventArgs e)
        {
            if (txtCity2.Text == "* Miasto")
            {
                txtCity2.Clear();
                txtCity2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void City2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity2.Text))
            {
                txtCity2.Text = "* Miasto";
                txtCity2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address2_Clear(object sender, EventArgs e)
        {
            if (txtAddress2.Text == "* Adres")
            {
                txtAddress2.Clear();
                txtAddress2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Address2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress2.Text))
            {
                txtAddress2.Text = "* Adres";
                txtAddress2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Zipcode2_Clear(object sender, EventArgs e)
        {
            if (txtZipcode2.Text == "* Kod pocztowy")
            {
                txtZipcode2.Clear();
                txtZipcode2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Zipcode2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtZipcode2.Text))
            {
                txtZipcode2.Text = "* Kod pocztowy";
                txtZipcode2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Born2_Clear(object sender, EventArgs e)
        {
            if (txtBorn2.Text == "* Data urodzenia")
            {
                txtBorn2.Clear();
                txtBorn2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Born2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBorn2.Text))
            {
                txtBorn2.Text = "* Data urodzenia";
                txtBorn2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country2_Clear(object sender, EventArgs e)
        {
            if (txtCountry2.Text == "* Kraj urodzenia")
            {
                txtCountry2.Clear();
                txtCountry2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Country2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountry2.Text))
            {
                txtCountry2.Text = "* Kraj urodzenia";
                txtCountry2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }


        private void Email2_Clear(object sender, EventArgs e)
        {
            if (txtEmail2.Text == "Email")
            {
                txtEmail2.Clear();
                txtEmail2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Email2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail2.Text))
            {
                txtEmail2.Text = "Email";
                txtEmail2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone2_Clear(object sender, EventArgs e)
        {
            if (txtPhone2.Text == "* Numer kontaktowy")
            {
                txtPhone2.Clear();
                txtPhone2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Phone2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone2.Text))
            {
                txtPhone2.Text = "* Numer kontaktowy";
                txtPhone2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment2_Clear(object sender, EventArgs e)
        {
            if (txtEmplacement2.Text == "Stanowisko")
            {
                txtEmplacement2.Clear();
                txtEmplacement2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void Employment2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmplacement2.Text))
            {
                txtEmplacement2.Text = "Stanowisko";
                txtEmplacement2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID2_Clear(object sender, EventArgs e)
        {
            if (txtID2.Text == "* Pesel")
            {
                txtID2.Clear();
                txtID2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }

        private void ID2_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID2.Text))
            {
                txtID2.Text = "* Pesel";
                txtID2.Font = new Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Regular)));
            }
        }
    }
}
