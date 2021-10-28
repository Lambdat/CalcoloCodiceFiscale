using System;

namespace CalcoloCodiceFiscale
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("daniele", "dolce", DateTime.Parse("2000-11-02"), "uomo", "roma");

            //Console.WriteLine(u.CreateSsn());

            u.CreateSsn(); //Richiamo il metodo void per effettuare il calcolo e caricare la proprietà Ssn

            Console.WriteLine(u.Ssn);
        }
    }
}
