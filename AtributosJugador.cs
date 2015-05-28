using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class AtributosJugador
    {
        private int porteria;
        private int salto;
        private int habilidad;
        private int presicion;
        private int potencia;
        Random r = new Random();// int aleatorio4 = r.Next(3, 12);dentro del rango


        public int Portería {get { return porteria; } }
        public int Salto { get { return salto; } }
        public int Habilidad { get { return habilidad; }  }
        public int Presicion { get { return presicion; }  }
        public int Potencia { get { return potencia; }  }

        public AtributosJugador(int p, int s, int h, int pre, int pot)
        {
            this.porteria = r.Next(1, p) + r.Next(1, s);
            this.habilidad = r.Next(1, h);
            this.presicion = r.Next(1, pre) + (habilidad / 2);
            this.potencia = r.Next(1, pre) + (habilidad / 2);
        }
       
    }
}
