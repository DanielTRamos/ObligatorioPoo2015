using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Defenza : Jugador
    {
        private AtributosJugador atributos;

         /**
          * @ param: recibe Nombre, Apellido y Edad. 
          * 
          * Crea un jugador Defenza con un random de (int kick, int regate, int atajar, int head, int pot
          */
        public Defenza (string name, string apel, int age)
        {
            base.nombre = name;
            base.apellido = apel;
            edad = age;
            this.posicion = "Defenza";
            atributos = new AtributosJugador(10, 3, 3, 10, 10);
        }
    }
}
