﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using static OurSelf.szablony;

namespace OurSelf
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> uzytkownik = new Dictionary<string, object>() {
                {"Login", login.Text},
                {"Haslo", haslo.Text},
                {"Email", email.Text},
                {"Wiek", (int)wiek.Value}
            };
            Google.DodajRekord("Konta", uzytkownik);
            MessageBox.Show("Powodzenie");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Google.Connect();
        }

        private void button2_ClickAsync(object sender, EventArgs e)
        {
            wyswietlAsync();
        }

        private async Task wyswietlAsync()
        {
            DocumentSnapshot dane = await Google.PobierzRekord("Konta", identyfikator.Text);

            User użytkownik = dane.ConvertTo<User>();

            pobranylogin.Text = użytkownik.Login.ToString();
            pobranyemail.Text = użytkownik.Email.ToString();
            pobranehaslo.Text = użytkownik.Haslo.ToString();
            pobranywiek.Value = użytkownik.Wiek;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> uzytkownik = new Dictionary<string, object>()
            {
                {"Login", pobranylogin.Text},
                {"Haslo", pobranehaslo.Text},
                {"Email", pobranyemail.Text},
                {"Wiek", (int)pobranywiek.Value}
            };
            Google.AktualizacjaRekordu("Konta", identyfikator.Text, uzytkownik);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Google.UsuwanieRekordu("Konta", identyfikator.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Google.UsuwaniePola("Konta", identyfikator.Text, komorka.Text);
        }
    }
}
