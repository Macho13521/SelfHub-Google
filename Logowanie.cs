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
    public partial class Logowanie : Form
    {
        
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            UtwórzKonto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Google.Connect();

            Google SkryptGoogle = new Google();

            DocumentReference docRef = Google.db.Collection("Konta").Document("d3yO0QwdvIc9tdl472J8");//nasłuchiwanie zmian
            FirestoreChangeListener listener = docRef.Listen(snapshot =>
            {
                MessageBox.Show("Aktualizacja Zmian");//ta funkcja się wywołuje po zmianach
            });

            listener.StopAsync();//wyłączenie nasłuchiwania
        }

        private void SkryptGoogle_Synchronizacja(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_ClickAsync(object sender, EventArgs e)
        {
            wyswietlAsync();
        }

        private async Task wyswietlAsync()
        {
 
            DocumentSnapshot dane = await Google.PobierzRekord("Konta", identyfikator.Text);
            
            if (dane.Exists)
            {
                User użytkownik = dane.ConvertTo<User>();
                pobranylogin.Text = użytkownik.Login.ToString();
                pobranyemail.Text = użytkownik.Email.ToString();
                pobranehaslo.Text = użytkownik.Haslo.ToString();
                pobranywiek.Value = użytkownik.Wiek;
            }
            else
            {
                Wyswietlkomunikat("Nie ma użytkownika o takim ID");
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            SzukajID();
        }

        public async Task SzukajID()
        {
            string ID = await Google.SzukajID("Konta", szukanepole.Text, szukanawartosc.Text);

            if (ID != null)
            {
                identyfikator.Text = ID;
            }
            else
            {
                Wyswietlkomunikat("Niema rekordu o takiej wartości");
            }
        }

        public void UtwórzKonto()
        {
            Dictionary<string, object> uzytkownik = new Dictionary<string, object>() {
                {"Login", login.Text},
                {"Haslo", haslo.Text},
                {"Email", email.Text},
                {"Wiek", (int)wiek.Value}
            };
            identyfikator.Text = Google.DodajRekord("Konta", uzytkownik);
        }

        public static void Wyswietlkomunikat(string komunikat)
        {
            MessageBox.Show(komunikat);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SzukajFrazyAsync();
        }

        private async Task SzukajFrazyAsync()
        {
            string ID = await Google.SzukajCiąguAsync("Konta",pole2.Text, szukanyciag.Text);
            znalezionyciag.Text = ID;   
        }
    }
}
