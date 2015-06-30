using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class FuenteDeArchivos
    {

        private string deporteros = ("C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/Arqueros.txt");
        private string deDelanteros = "C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/Atacantes.txt";
        private string deDefenzas = "C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/Defenzas.txt";
        private string deMedioCampo = "C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/MedioCampo.txt";
        private string deArbitros = "C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/Arbitro.txt";

        // --------------------------------Get / Set 
        public string Deporteros
        {
            get { return deporteros; }
            set { deporteros = value; }
        }

        public string DeDelanteros
        {
            get { return deDelanteros; }
            set { deDelanteros = value; }
        }

        public string DeDefenzas
        {
            get { return deDefenzas; }
            set { deDefenzas = value; }
        }

        public string DeMedioCampo
        {
            get { return deMedioCampo; }
            set { deMedioCampo = value; }
        }

        public string DeArbitros
        {
            get { return deArbitros; }
            set { deArbitros = value; }
        }

    }
}
