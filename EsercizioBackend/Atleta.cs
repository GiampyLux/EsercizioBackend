using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBackend
{
    internal class Atleta
    {
        string nome;
        string cognome;
        string sport;



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public string Sport {
            get { return sport; }
            set { sport = value; }
        }

        public void description()
        {
            Console.WriteLine("Mi chiamo " + nome + " " + cognome + " e pratico " + sport); //provo per committare
        }
    }
}
