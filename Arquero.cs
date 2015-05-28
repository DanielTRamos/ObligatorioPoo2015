using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Arquero : Jugador
    {
        private string equipo;

        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }
       

        /** Constructor : nombre apellido, máximo en porteria, salto, habilidad, int presición, int potencia*/
        public Arquero (string nombre, string apellido)
             : base(nombre,apellido, 10, 10, 4, 4, 6)            
        {          

        }
    }
}
