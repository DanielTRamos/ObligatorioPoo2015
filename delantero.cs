using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Delantero : Jugador
    {
         AtributosJugador atributos;

         /**
          * @ param: recibe (int kick, int regate, int parar, int head, int pot
          */
         public Delantero(string name, string apel, int age)
        {
            base.nombre = name;
            base.apellido = apel;
            edad = age;
            this.posicion = posicion;
            atributos = new AtributosJugador(5, 2, 10, 10, 10);
        }
    }
}
