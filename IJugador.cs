﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    interface IJugador:IPersona
    {
        String Posición { get; set; }
        int Patear { get; }
        int Cabecear { get; }
        int Atajar { get; }
        int Regatear { get; }
        int TirarTiroLibre { get; }
        int GolesHechos { get; set; }
        void SetEquipo(IEquipo team);
        IEquipo GetEquipo();
    }
}