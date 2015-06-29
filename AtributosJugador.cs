using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class AtributosJugador
    {
        private int patear;
        private int regatear;
        private int atajar;
        private int cabecear;
        private int tirarTirosLibres;

        public int Patear
        {
            get { return patear; }
            set { patear = value; }
        }

        public int Regatear
        {
            get { return regatear; }
            set { regatear = value; }
        }

        public int Atajar
        {
            get { return atajar; }
            set { atajar = value; }
        }

        public int Cabecear
        {
            get { return cabecear; }
            set { cabecear = value; }
        }

        public int TirarTirosLibres
        {
            get { return tirarTirosLibres; }
            set { tirarTirosLibres = value; }
        }

        Random r = new Random();// int aleatorio4 = r.Next(3, 12);dentro del rango


        public AtributosJugador(int kick, int regate, int parar, int head, int pot)
        {
            this.patear = r.Next(1, kick);
            this.regatear = r.Next(1, regate);
            this.atajar = r.Next(1, parar) ;
            this.cabecear = r.Next(1, head);
            this.tirarTirosLibres = r.Next(1, pot);

        }
    }
}
