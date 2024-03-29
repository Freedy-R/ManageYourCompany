﻿using MySql.Data.MySqlClient;
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
    public partial class modyfikuj_obiekt : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=mysql8001.site4now.net;User=a877f4_sklepik;Database=db_a877f4_sklepik;Password=kamilos04;");// W przypadku braku połączenia i problemów za komentarzować i odkomentarzować poniższy
        //MySqlConnection connection = new MySqlConnection("Server=localhost;User=root;Database=sklep;Password=;"); //Pamiętaj by stworzyć za pomocą xamppa bazę sklep i zaimportować z folderu baza danych
        bool polaczony = false;
        int wybrano;
        string adres, nazwaObiektu, kodP, miejscowosc, telefon;
        public modyfikuj_obiekt(int wybrano, string adres, string nazwaObiektu, string kodP,string miejscowosc, string telefon)
        {
            InitializeComponent();
            this.wybrano = wybrano;
            this.adres = adres;
            this.nazwaObiektu = nazwaObiektu;
            this.kodP = kodP;
            this.miejscowosc = miejscowosc;
            this.telefon = telefon;
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

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            tworzenie_pol();
            MySqlCommand modyfikacja = new MySqlCommand("UPDATE obiekty SET Nazwa_obiektu='"+txtNazwaObiektu.Text+"', Adres='"+txtAdres.Text+"', Kod_Pocztowy='"+txtKodPocztowy.Text+"', Miejscowosc='"+txtMiejscowosc.Text+"', Telefon='"+txtNumer.Text+"' WHERE ID ="+wybrano,connection);
            modyfikacja.ExecuteNonQuery();
            MessageBox.Show("Zmiana Udana");
            fMenu form = new fMenu();
            form.Show();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            fMenu form = new fMenu();
            form.Show();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modyfikuj_obiekt_Load(object sender, EventArgs e)
        {
            tworzenie_pol();
            txtAdres.Text = adres;
            txtNazwaObiektu.Text = nazwaObiektu;
            txtMiejscowosc.Text = miejscowosc;
            txtKodPocztowy.Text = kodP;
            txtNumer.Text = telefon;
            niszczenie_pol();

        }
    }
}
