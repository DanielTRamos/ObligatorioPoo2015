using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    public abstract class Jugador : IPersona
    {
        private string nombre;
        private string apellido;
        private int atajar;
        private int patear;
        private int cabecear;
        private int regatear;
        private int tirarTirosLibres;
        private AtributosJugador atributos;        
        

       /** get / set */        

        public String Nombre { get { return nombre; } }
        public String Apellido { get { return apellido; } }

        abstract public void Atajar();       
        abstract void Patear();
        abstract void Cabecear();
        abstract void Regatear();
        abstract void TirarTirosLibres();

        

        /** Constructor */

        public Jugador(string nom, string apell, int p, int s, int h, int pre, int pot) 
        {
            this.nombre = nom;
            this.apellido = apell;
            atributos = new AtributosJugador(p, s, h, pre, pot);            
        }
        
    }
}
