using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    interface IEscuelaDeJugadores
    {
        IJugador BrindarArquero();
        IJugador BrindarDelantero();
        IJugador BrindarMedioCampo();
        IJugador BrindarDefenza();
    }
}
