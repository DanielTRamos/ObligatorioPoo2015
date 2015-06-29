using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Jugador : IJugador
    {
        protected string posicion;
        protected string nombre;
        protected string apellido;
        protected int edad;        
        protected int patear;
        protected int cabecear;
        protected int atajar;
        protected int regatear;
        protected int tirarTiroLibre;
        protected int golesHechos;
        AtributosJugador atributos;

        public string Posicion
        {
            get
            {
                return posicion;
            }
            set
            {
                this.posicion = value;
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
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        /*
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
        */
        public void Presentarse()
        {
            Console.WriteLine("Mi nombre es : "+ nombre.ToString()+" "+ apellido.ToString()+ " tengo "+ edad.ToString() + " años y juego de "+ posicion.ToString());
        }
    }
}
