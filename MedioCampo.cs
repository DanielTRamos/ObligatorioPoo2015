using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class MedioCampo : Jugador
    {
         private AtributosJugador atributos;

         /**
          * @ param: recibe Nombre, Apellido y Edad. 
          * 
          * Crea un jugador Medio Campo con un random de (int kick, int regate, int atajar, int head, int pot
          */
         public MedioCampo (string name, string apel, int age)
        {
            base.nombre = name;
            base.apellido = apel;
            edad = age;
            this.posicion = "Medio Campo";
            atributos = new AtributosJugador(10, 10, 3, 10, 10);
        }
    }
}
