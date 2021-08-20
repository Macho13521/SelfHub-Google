using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace OurSelf
{
    class szablony
    {
        [FirestoreData]
        public class User
        {
            [FirestoreProperty]
            public string Login { get; set; }
            [FirestoreProperty]
            public string Haslo { get; set; }
            [FirestoreProperty]
            public string Email { get; set; }
            [FirestoreProperty]
            public int Wiek { get; set; }
        }
    }
}
