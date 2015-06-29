using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Arquero:Jugador
    {
        AtributosJugador atributos;

        public Arquero (string name, string apel, int age)
        {
            base.nombre = name;
            base.apellido = apel;
            edad = age;
            this.posicion = posicion;
            atributos = new AtributosJugador(5, 2, 10, 10, 10);
        }
    }

}
