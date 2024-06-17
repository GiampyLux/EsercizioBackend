using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBackend
{
    internal class Veicolo
    {
        string nome;
        string marca;
        int immatricolazione;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Immatricolazione
        {
            get { return immatricolazione; }
            set { immatricolazione = value; }

        }

        public void description()
        {
            Console.WriteLine("Sono " + nome + " di marca " + marca + " dell'anno " + immatricolazione);
        }
    }
}
