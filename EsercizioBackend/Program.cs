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

            Animale b = new Animale();
            b.Nome = "Fido";
            b.Razza = "Labrador";
            b.Tipo = "Cane";
            b.description();

            Dipendente c = new Dipendente();
            c.Nome = "Giacomo";
            c.Cognome = "Moro";
            c.Lavoro = "Sicario";
            c.description();

            Veicolo d = new Veicolo();
            d.Nome = "Michele";
            d.Marca = "Panda";
            d.Immatricolazione = 2000;
            d.description();
        }
    }
}
