using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ObligatorioPoo2015
{
    class Equipo:IEquipo
    {
        private String nombreEquipo;
        private ArrayList listaJugadoresEquipo = new ArrayList();
        private Int32 golesRecibidos;
        private Int32 puntosEnTorneo;

        public Equipo(String nombre)
        {
            nombreEquipo = nombre;
            golesRecibidos = 0;
            puntosEnTorneo = 0;
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

        public ArrayList ListaJugadoresEquipo
        {
            get { return listaJugadoresEquipo; }
        }

        public void adquirirJugador(IJugador jugador)
        {
            listaJugadoresEquipo.Add(jugador);
        }
    }
}
