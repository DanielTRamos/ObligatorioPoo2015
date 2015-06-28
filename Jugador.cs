using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Jugador : IJugador
    {
        private string posicion;
        private string nombre;
        private string apellido;
        private int edad;
        private string posición;
        private int patear;
        private int cabecear;
        private int atajar;
        private int regatear;
        private int tirarTiroLibre;
        private int golesHechos;

        public string Posición
        {
            get
            {
                return posicion;
            }
            set
            {
                posicion = value;
            }
        }

        public int Patear
        {
            get { return patear; }
        }

        public int Cabecear
        {
            get { return cabecear; }
        }

        public int Atajar
        {
            get { return atajar; }
        }

        public int Regatear
        {
            get { return regatear; }
        }

        public int TirarTiroLibre
        {
            get { return tirarTiroLibre; }
        }

        public int GolesHechos
        {
            get
            {
                return golesHechos;
            }
            set
            {
                golesHechos = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Edad
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Jugador(string name, string apel, int age, string posicion,  int patear, int cabecear, int atajar, int regatear, int tirarTiroLibre)
        {
            nombre = name;
            apellido = apel;
            edad = age;
            this.posicion = posicion;
            this.patear = patear;
            this.cabecear = cabecear;
            this.atajar = atajar;
            this.regatear = regatear;
            this.tirarTiroLibre = tirarTiroLibre;
            golesHechos = 0;


        }
    }
}
