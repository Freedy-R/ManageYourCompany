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
            var qwszukanie = "SELECT * FROM pracownicy WHERE column LIKE '%" + szukam + "%'";
            if (szukam != "")
                ladowanie_bazy(qwszukanie);
        }
}
}
