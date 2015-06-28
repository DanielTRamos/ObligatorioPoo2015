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
        private ArrayList listaJugadoresEquipo;
        private Int32 golesRecibidos;
        private Int32 puntosEnTorneo;

        public Equipo(String nombre)
        {
            nombreEquipo = nombre;
            golesRecibidos = 0;
            puntosEnTorneo = 0;
            listaJugadoresEquipo = new ArrayList();
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



        public Int32 AdquirirJugador(IJugador j)
        {
            if (listaJugadoresEquipo.Contains(j))
            {
                Console.WriteLine("El jugador ya está en el equipo ");
                return -1;
            }
            else
            {
                listaJugadoresEquipo.Add(j);
                Console.WriteLine("El jugador fue agregado al equipo ");
                return 1;
            }
        }
    }
}
