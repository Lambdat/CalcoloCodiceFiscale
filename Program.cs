using System;

namespace CalcoloCodiceFiscale
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("antonio", "orefice", DateTime.Parse("1998-02-24"), "uomo", "napoli");

            u.Ssn = u.CreateSsn(); //Richiamo il metodo per effettuare il calcolo e valorizzare la proprietà string Ssn

            Console.WriteLine($"Codice Fiscale calolato di {u.FirstName.ToUpper()} {u.LastName.ToUpper()}: \n" +
                $"{u.Ssn}");
        }
    }
}
