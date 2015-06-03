using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    class Arquero : Jugador
    {
              

        /** Constructor : nombre apellido, máximo en porteria, salto, habilidad, presición, potencia*/
        public Arquero (string nombre, string apellido)
             : base(nombre,apellido, 10, 10, 3, 3, 5)            
        {          

        }
    }
}
