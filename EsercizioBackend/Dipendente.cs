using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBackend
{
    internal class Dipendente
    {
        
        
        string nome;
        string cognome;
        string lavoro;




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

        public string Lavoro
        {
            get { return lavoro; }
            set { lavoro = value; }
        }

        public void description()
        {
            Console.WriteLine(" Ciao Piacere Mi Chiamo " + nome + " " + cognome + " e il mio Lavoro è " + lavoro);
        }
    }
}
