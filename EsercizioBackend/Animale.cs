﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBackend
{
    internal class Animale
    {
        
        string nome;
        string razza;
        string tipo;



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Razza
        {
            get { return razza; }
            set { razza = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public void description()
        {
            Console.WriteLine(" BAU BAU Mi chiamo " + nome + " Sono un " + razza + " e sono un " + tipo);
        }
    }
}

