using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    interface IArbitro: IPersona
    {
        String Posicion { get; set; }
        Int32 Arbitrar { get; set; }
    }
}
