using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObligatorioPoo2015
{
    class EscuelaDeJugadores : IEscuelaDeJugadores
    {
        private IList<IJugador> arqueros = new List<IJugador>();
        private IList<IJugador> delanteros = new List<IJugador>();
        private IList<IJugador> defenzas = new List<IJugador>();
        private IList<IJugador> medioCampos = new List<IJugador>();
        FuenteDeArchivos fuente;

        public EscuelaDeJugadores()
        {
            Console.WriteLine("Comienza");
            fuente = new FuenteDeArchivos();
            CargarJugadores();           
        }

        public void CargarJugadores()
        {
            arqueros = CargarPorteros(fuente.Deporteros);            
            delanteros = CargarDelantero(fuente.DeDelanteros);
           
        }
            
        /// <summary>
        /// De la lista de jugadores, brinda el primero y sucesivamente hasta el último. sin repetir.
        /// </summary>
        /// <returns></returns>
        public IJugador BrindarArquero()
        {
            if (arqueros.Count != 0)
            {
                IJugador jj = arqueros.ElementAt(0);
                arqueros.RemoveAt(0);
                return jj;
            }
            else
            {
                Console.WriteLine("ERROR - no se han cargado los arqueros ");
                return null;
            }
        }

        public IJugador BrindarDelantero()
        {
            if (delanteros.Count != 0)
            {
                IJugador jj = delanteros.ElementAt(0);
                delanteros.RemoveAt(0);
                return jj;
            }
            else
            {
                Console.WriteLine("ERROR - no se han cargado los delanteros ");
                return null;
            }
        }

        public IJugador BrindarMedioCampo()
        {
            if (medioCampos.Count != 0)
            {
                IJugador jj = medioCampos.ElementAt(0);
                medioCampos.RemoveAt(0);
                return jj;
            }
            else
            {
                Console.WriteLine("ERROR - no se han cargado los medioCampos ");
                return null;
            }
        }

        public IJugador BrindarDefenza()
        {
            if (defenzas.Count != 0)
            {
                IJugador jj = defenzas.ElementAt(0);
                defenzas.RemoveAt(0);
                return jj;
            }
            else
            {
                Console.WriteLine("ERROR - no se han cargado los defenzas ");
                return null;
            }
        }


        /// <summary>
        /// Carga los jugadores desde el txt a una lista.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        private List<IJugador> CargarPorteros(string texto)
        {
            ManejadorArchivos lector = new ManejadorArchivos();
            List<IJugador> lista = new List<IJugador>();
            ArrayList datos = lector.Leer(texto);
            foreach (String linea in datos)
            {
                object[] celdas = linea.Split(',');
                Console.WriteLine(celdas.Length.ToString());
                String nombre = Convert.ToString(celdas[0]);
                String apellido = Convert.ToString(celdas[1]);
                Int32 edad = Convert.ToInt32(celdas[2]);

                IJugador portero = new Arquero (nombre, apellido, edad );
                lista.Add(portero);
                Console.WriteLine(nombre, " , ", apellido);

                
            }
            return lista;
        }

        private List<IJugador> CargarDelantero(string texto)
        {
            ManejadorArchivos lector = new ManejadorArchivos();
            List<IJugador> lista = new List<IJugador>();
            ArrayList datos = lector.Leer(texto);
            foreach (String linea in datos)
            {
                object[] celdas = linea.Split(',');
                Console.WriteLine(celdas.Length.ToString());
                String nombre = Convert.ToString(celdas[0]);
                String apellido = Convert.ToString(celdas[1]);
                Int32 edad = Convert.ToInt32(celdas[2]);
                IJugador delantero = new Delantero(nombre, apellido, edad);
                lista.Add(delantero);                
            }
            return lista;
        }
    }
}
