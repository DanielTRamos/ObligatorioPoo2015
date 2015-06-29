using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Arquero:Jugador
    {

        private AtributosJugador atributos;

        /**
         * @ param: recibe Nombre, Apellido y Edad. 
         * 
         * Crea un jugador Arquero con un random de (int kick, int regate, int atajar, int head, int pot
         */
        public Arquero (string name, string apel, int age)
        {
            base.nombre = name;
            base.apellido = apel;
            edad = age;
            this.posicion = "Arquero";
            atributos = new AtributosJugador(5, 2, 10, 10, 10);
        }
    }

}
