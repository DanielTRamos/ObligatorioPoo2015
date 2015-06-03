using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Equipo
    {
        private String nombre;
        private List<Jugador> jugadores = new List<Jugador>();
        private Arquero numero1 = new Arquero ("Jorge", "Baba");

        private Arquero numero2 = new Arquero("Esteban", "Quito");



        public String Nombre { get { return nombre; }}

        //public Jugador JugadoresDelEquipo { }
        public Equipo (String name){
            nombre = name;
            jugadores.Add (numero1);
            jugadores.Add(numero2);
            
    }

        
        /* lista de jugadores que conforman el equipo */
        public String conformacion ()
        {
            StringBuilder l = new StringBuilder();
            foreach (Jugador i in jugadores)
            {
                l.Append("Nombre:  ").Append(i.Nombre.ToString()).Append(" , Apellido:  ").Append(i.Apellido.ToString()).Append(" | "); ;

            }
            string result = l.ToString(); // Get string from StringBuilder
            Console.WriteLine(result);
            return result;
        }





    }
}
