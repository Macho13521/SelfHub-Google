using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static OurSelf.szablony;

namespace OurSelf
{
    public class Google
    {
        static FirestoreDb db;


        public static void Connect()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"selfhub.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("selfhub");
        }

        
        public static void DodajRekord(string Kolekcja, Dictionary<string, object> dane)
        {
            CollectionReference kolekcja = db.Collection(Kolekcja);

            kolekcja.AddAsync(dane);
        }

        public static async Task<DocumentSnapshot> PobierzRekord(string Kolekcja, string ID)
        {
            DocumentReference warunki = db.Collection(Kolekcja).Document(ID);
            DocumentSnapshot zapytanie = await warunki.GetSnapshotAsync();

            if (zapytanie.Exists)
            {
                return zapytanie;
            }
            else
            {
                return null;
            }
        }
        /*
        
        private async Task wyswietlAsync()    - przykład korzystania z funkcji pobierania danych do klass po ID -- PobierzRekord
        {
            DocumentSnapshot dane = await Google.PobierzRekordAsync("Konta", identyfikator.Text);

            User użytkownik = dane.ConvertTo<User>();

            wynik.Text = użytkownik.Wiek.ToString();
        }

        */
    }
}
