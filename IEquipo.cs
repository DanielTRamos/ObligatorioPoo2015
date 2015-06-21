using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObligatorioPoo2015
{
    interface IEquipo
    {
        
        String NombreEquipo { get; }
        Int32 GolesRecibidos { get; set; }
        Int32 PuntosEnTorneo { get; set; }
        ArrayList ListaJugadoresEquipo {get;}
    
    }
}
