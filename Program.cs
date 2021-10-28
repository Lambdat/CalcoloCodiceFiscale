using System;

namespace CalcoloCodiceFiscale
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("antonio", "orefice", DateTime.Parse("1998-02-24"), "uomo", "napoli");

            //Console.WriteLine(u.CreateSsn());

            u.CreateSsn(); //Richiamo il metodo void per effettuare il calcolo e caricare la proprietà Ssn

            Console.WriteLine(u.Ssn);
        }
    }
}
