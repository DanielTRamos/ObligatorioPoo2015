using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ObligatorioPoo2015
{
    class Equipo : IEquipo
    {
        private String nombreEquipo;
        private List<IJugador> listaJugadoresEquipo;
        private Int32 golesRecibidos;
        private Int32 puntosEnTorneo;

        public Equipo(String nombre)
        {
            nombreEquipo = nombre;
            golesRecibidos = 0;
            puntosEnTorneo = 0;
            listaJugadoresEquipo = new List<IJugador>();
        }


        public string NombreEquipo
        {
            get { return nombreEquipo; }
        }

        public int GolesRecibidos
        {
            get
            {
                return golesRecibidos;

            }
            set
            {
                golesRecibidos = value;
            }
        }

        public int PuntosEnTorneo
        {
            get
            {
                return puntosEnTorneo;
            }
            set
            {
                puntosEnTorneo = value;
            }
        }

        /// <summary>
        /// Devuelve la lista de jugadores del equipo
        /// </summary>
        public IList<IJugador> ListaJugadoresEquipo
        {
            get { return listaJugadoresEquipo; }
        }        
        
        public bool AdquirirJugador(IJugador j)
        {
            if (listaJugadoresEquipo.Contains(j))
            {
                Console.WriteLine("El jugador ya está en el equipo ");
                return false;
            }
            else
            {
                listaJugadoresEquipo.Add(j);
                Console.WriteLine("El jugador fue agregado al equipo ");
                return true;
            }
        }

        public void presentarJugadores()
        {
            foreach (IJugador j in listaJugadoresEquipo)
            {
                j.Presentarse();
            }
        }


    }
}
