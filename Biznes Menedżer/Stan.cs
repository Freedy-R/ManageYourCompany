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
        MySqlConnection connection = new MySqlConnection("Server=mysql8001.site4now.net;User=a877f4_sklep;Database=db_a877f4_sklep;Password=kamilos04;");// W przypadku braku połączenia i problemów za komentarzować i odkomentarzować poniższy
        //MySqlConnection connection = new MySqlConnection("Server=localhost;User=root;Database=sklep;Password=;"); //Pamiętaj by stworzyć za pomocą xamppa bazę sklep i zaimportować z folderu baza danych
        public int maxIlosc, idTowar, podatekTowaru, wybranoO;
        public decimal cenaNettoTowaru, cenaBruttoTowaru;
        public string nazwaTowaru, producentTowaru, nr_fakturyTowaru, stanTowaru;
        bool polaczony = false;
        int a = 10;
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
                new MySqlCommand(
                    ""
                ,connection);
            {
                zmien.ExecuteNonQuery();
                zmien.CommandTimeout = 3600;
                MessageBox.Show("Zmieniono");
                niszczenie_pol();
            }

        }
    }
}
