using System.ComponentModel;

namespace EsercizioBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta a = new Atleta();
            a.Nome = "Giovanni";
            a.Cognome = "De Blasi";
            a.Sport = "Padel";
            a.description();
        }
    }
}
