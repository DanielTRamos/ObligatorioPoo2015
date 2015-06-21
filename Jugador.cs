using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    public class Jugador : IJugador
    {
        /**
         * 
         * @author: Luis TITO
         * @param: Interfase.
         * /
        /* ----------------------------------Datos del Jugador ____  */
        private string nombre;
        private string apellido;
        private int edad;
        /* ----------------------------------Atributos del Jugador ____  */
        private string posicion;
        private int patear;
        private int cabecear;
        private int atajar;
        private int regatear;
        private int tirarTiroLibre;

        /* ----------------------------------Variables del Jugador ____  */
        private int goles;
        private IEquipo equipo;


        /* ----------------------------------Atributos ____  */
        public string Posición
        {
            get { return posicion; }
            set { posicion = value; }
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

        /* ----------------------------------Variables ____  */
        public int GolesHechos
        {
            get
            {
                return goles;
            }
            set
            {
                goles = value;
            }
        }

        public void SetEquipo(IEquipo team)
        {
            equipo = team;
        }

        public IEquipo GetEquipo()
        {
            return equipo;
        }

        /* ----------------------------------Datos  ____  */

      public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
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
    }
}
