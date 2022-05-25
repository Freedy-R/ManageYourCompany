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
    
    public partial class fStan : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=sql11.freemysqlhosting.net;User=sql11495118;Database=sql11495118;Password=TmiBWjhEKf;");// W przypadku braku połączenia i problemów za komentarzować i odkomentarzować poniższy
        //MySqlConnection connection = new MySqlConnection("Server=localhost;User=root;Database=sklep;Password=;"); //Pamiętaj by stworzyć za pomocą xamppa bazę sklep i zaimportować z folderu baza danych
        public int maxIlosc, idTowar, podatekTowaru, wybranoO;
        public decimal cenaNettoTowaru, cenaBruttoTowaru;
        public string nazwaTowaru, producentTowaru, nr_fakturyTowaru, stanTowaru;
        bool polaczony = false;
        public fStan(int wybranoO,int maxIlosc, int idTowaru, string nazwaTowaru, string producentTowaru, string nr_fakturyTowaru, int podatekTowaru, decimal cenaNettoTowaru, decimal cenaBruttoTowaru, string stanTowaru)
        {
            this.wybranoO = wybranoO;
            this.idTowar = idTowaru;
            this.maxIlosc = maxIlosc;
            this.nazwaTowaru = nazwaTowaru;
            this.producentTowaru = producentTowaru;
            this.nr_fakturyTowaru = nr_fakturyTowaru;
            this.podatekTowaru = podatekTowaru;
            this.cenaNettoTowaru = cenaNettoTowaru;
            this.cenaBruttoTowaru = cenaBruttoTowaru;
            this.stanTowaru = stanTowaru;
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

        private void fStan_Enter(object sender, EventArgs e)
        {
            numIlosc.Maximum = maxIlosc;
            numIlosc.Value = numIlosc.Maximum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tworzenie_pol();
            MySqlCommand zmien =
                new MySqlCommand(" UPDATE towar SET Ilosc = Ilosc +" + ( Convert.ToInt32(numIlosc.Value.ToString())) + " WHERE Nazwa = '" + nazwaTowaru + "' AND Producent = '" + producentTowaru + "' AND Nr_Faktury = " + podatekTowaru + " AND Cena_Netto = '" + cenaNettoTowaru + "' AND Cena_Brutto = '" + cenaBruttoTowaru + "' AND Stan = '" + cbStan.GetItemText(cbStan.SelectedItem) + "'AND (SELECT COUNT(*) FROM towar WHERE Nazwa = '" + nazwaTowaru + "' AND Producent = '" + producentTowaru + "' AND Nr_Faktury = '" + podatekTowaru + "' AND Cena_Netto = '" + cenaNettoTowaru + "' AND Cena_Brutto = '" + cenaBruttoTowaru + "' AND Stan = '" + cbStan.GetItemText(cbStan.SelectedItem) + "') = 1; UPDATE towar SET Ilosc = Ilosc -" + (Convert.ToInt32(numIlosc.Value)) + " WHERE ID = '" + idTowar + "'AND (SELECT COUNT(*) FROM towar WHERE Nazwa = '" + nazwaTowaru + "' AND Producent = '" + producentTowaru + "' AND Nr_Faktury = '" + podatekTowaru + "' AND Cena_Netto = '" + cenaNettoTowaru + "' AND Cena_Brutto = '" + cenaBruttoTowaru + "' AND Stan = '" + cbStan.GetItemText(cbStan.SelectedItem) + "') = 1; INSERT INTO towar (ID_obiektu, Nazwa, Ilosc, Producent, Nr_Faktury, Podatki, Cena_Netto, Cena_Brutto, Stan) VALUES ('" + wybranoO + "', '" + nazwaTowaru + "', '" + Convert.ToInt32(numIlosc.Value.ToString()) + "', '" + producentTowaru + "', '" + nr_fakturyTowaru + "', '" + podatekTowaru + "', '" + cenaNettoTowaru + "', '" + cenaBruttoTowaru + "', '" + cbStan.GetItemText(cbStan.SelectedItem) + "' WHERE (SELECT COUNT(*) FROM towar WHERE Nazwa = '" + nazwaTowaru + "' AND Producent = '" + producentTowaru + "' AND Nr_Faktury = '" + podatekTowaru + "' AND Cena_Netto = '" + cenaNettoTowaru + "' AND Cena_Brutto = '" + cenaBruttoTowaru + "' AND Stan = '" + cbStan.GetItemText(cbStan.SelectedItem) + "') = 0; UPDATE towar SET Ilosc = Ilosc'" + (Convert.ToInt32(numIlosc.Value.ToString())) + "' WHERE ID = '" + idTowar + " AND (SELECT COUNT(*) FROM towar WHERE Nazwa = '" + nazwaTowaru + "' AND Producent = '" + producentTowaru + "' AND Nr_Faktury = '" + podatekTowaru + "' AND Cena_Netto = '" + cenaNettoTowaru + "' AND Cena_Brutto = '" + cenaBruttoTowaru + "' AND Stan = '" + cbStan.GetItemText(cbStan.SelectedItem) + "') = 0;", connection);
            if (numIlosc.Value != 0)
            {
                zmien.ExecuteNonQuery();
                zmien.CommandTimeout = 3600;
                MessageBox.Show("Zmieniono");
                niszczenie_pol();
            }

        }
    }
}
