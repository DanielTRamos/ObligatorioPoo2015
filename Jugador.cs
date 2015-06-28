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
        private IEquipo team;


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

        public void SetEquipo(Equipo team)
        {
            this.team = team;
        }

        public IEquipo GetEquipo()
        {
            return team;
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

        /**
         * Constructor:
         * @author: Luis TITO
         * @param: String posicion, String nombre, Int32 edad, String apellido, Int32 patear, Int32 cabecear, Int32 atajar, Int32 regatear, Int32 tirarTiroLibre, IEquipo equipo)
         */
        public Jugador(string posicion, string nombre, Int32 edad, string apellido, Int32 patear, Int32 cabecear, Int32 atajar, Int32 regatear, Int32 tirarTiroLibre, IEquipo team)
        {
            this.posicion = posicion;
            this.nombre = nombre;
            this.edad = edad;
            this.apellido = apellido;
            this.patear = patear;
            this.cabecear = cabecear;
            this.atajar = atajar;
            this.regatear = regatear;
            this.tirarTiroLibre = tirarTiroLibre;
            this.team = team;
            this.goles = 0;
        }
    }
}
