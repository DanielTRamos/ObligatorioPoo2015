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
        protected int golesHechos;
        AtributosJugador atributos;

       
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

       // Metodo de verificación de correctitud de datos del jugador.
        public void Presentarse()
        {
            Console.WriteLine("Mi nombre es : "+ nombre.ToString()+" "+ apellido.ToString()+ " tengo "+ edad.ToString() + " años y juego de "+ posicion.ToString());
        }
    }
}
