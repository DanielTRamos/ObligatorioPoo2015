using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPoo2015
{
    interface IJugador:IPersona
    {        
        int GolesHechos { get; set; }
        void Presentarse();
    }
}
