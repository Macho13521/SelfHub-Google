using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static OurSelf.Logowanie;

namespace OurSelf
{
    public class Google
    {
        public static FirestoreDb db;


        public static void Connect()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"selfhub.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("selfhub"); 
        }


        public static void Komunikat(int nr)
        {
            string komunikat="";
            switch (nr)
            {
                case 1:
                    komunikat = "Dodawanie rekordu zakończone niepowodzeniem";
                    break;
                case 2:
                    komunikat = "Pobieranie rekordu zakończone niepowodzeniem";
                    break;
                case 3:
                    komunikat = "Aktualizacja rekordu zakończona niepowodzeniem";
                    break;
                case 4:
                    komunikat = "Usuwanie rekordu zakończone niepowodzeniem";
                    break;
                case 5:
                    komunikat = "Usuwanie pola zakończone niepowodzeniem";
                    break;
                case 6:
                    komunikat = "Szukanie ID zakończone niepowodzeniem";
                    break;
            }
            try
            {
                Logowanie.Wyswietlkomunikat(komunikat);
            }
            catch
            {
                Logowanie.Wyswietlkomunikat("Błąd orzetwarzania komunikatów");
            }
        }

        
        public static string DodajRekord(string Kolekcja, Dictionary<string, object> dane)
        {
            try
            {
                CollectionReference kolekcja = db.Collection(Kolekcja);
                string ID = kolekcja.AddAsync(dane).Result.Id;
                return ID;
            }
            catch
            {
                Komunikat(1);
                return null;
            }
        }

        public static async Task<DocumentSnapshot> PobierzRekord(string Kolekcja, string ID)
        {
            try
            {
                DocumentReference warunki = db.Collection(Kolekcja).Document(ID);
                DocumentSnapshot zapytanie = await warunki.GetSnapshotAsync();
                return zapytanie;
            }
            catch
            {
                Komunikat(2);
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


        public static async Task AktualizacjaRekordu(string Kolekcja, string ID, Dictionary<string, object> dane)
        {
            try
            {
                DocumentReference warunki = db.Collection(Kolekcja).Document(ID);
                DocumentSnapshot Sprawdzenie = await warunki.GetSnapshotAsync();
                await warunki.UpdateAsync(dane);
            }
            catch
            {
                Komunikat(3);
            }
        }


        public static void UsuwanieRekordu(string Kolekcja, string ID)
        {
            try
            {
                DocumentReference warunki = db.Collection(Kolekcja).Document(ID);
                warunki.DeleteAsync();
            }
            catch
            {
                Komunikat(4);
            }
        }

        public static void UsuwaniePola(string Kolekcja, string ID, string Pole)
        {
            try
            {
                DocumentReference warunki = db.Collection(Kolekcja).Document(ID);

                Dictionary<string, object> dane = new Dictionary<string, object>()
                {
                    {Pole, FieldValue.Delete}
                };
                warunki.UpdateAsync(dane);
            }
            catch
            {
                Komunikat(5);
            }  
        }


        public static async Task<string> SzukajID(string Kolekcja, string NazwaPola, dynamic WartośćPola)
        {
            try
            {
                CollectionReference kolekt = db.Collection(Kolekcja);
                Query kwerenda = kolekt.WhereEqualTo(NazwaPola, WartośćPola);

                QuerySnapshot zwrot = await kwerenda.GetSnapshotAsync();

                if (zwrot.Documents.Count == 1)
                {
                    return zwrot.Documents[0].Id;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                Komunikat(6);
                return null;
            }
        }

        public async Task<List<List<dynamic>>> PobierzRekordy(string Kolekcja, string Pole, string WartośćPola)
        {
            Query capitalQuery = db.Collection(Kolekcja).WhereEqualTo(Pole, WartośćPola);
            QuerySnapshot capitalQuerySnapshot = await capitalQuery.GetSnapshotAsync();

            List<List<dynamic>> Rekordy = new List<List<dynamic>>();
            List<dynamic> Rekord = new List<dynamic>();

            foreach (DocumentSnapshot documentSnapshot in capitalQuerySnapshot.Documents)
            {
                Rekord.Clear();
                Console.WriteLine("Document data for {0} document:", documentSnapshot.Id);
                Dictionary<string, object> city = documentSnapshot.ToDictionary();
                foreach (KeyValuePair<string, object> pair in city)
                {
                    Rekord.Add(pair.Value);
                }
                Rekordy.Add(Rekord);
            }

            if (Rekordy.Count > 0)
            {
                return Rekordy;
            }
            else
            {
                return null;
            }

            
        }
    }
}
