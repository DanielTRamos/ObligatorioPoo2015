using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObligatorioPoo2015
{
    class FabricaDeEquipos
    {
        private IList<IEquipo> cuadros = new List<IEquipo>();
        FuenteDeArchivos fuente;
        private string archivoDeLista;

         public FabricaDeEquipos()
        {
            Console.WriteLine("Comienza");
            fuente = new FuenteDeArchivos();
            archivoDeLista = fuente.DeEquipos;
            cuadros = CargarEquipos();           
        }

         public IEquipo BrindarEquipo()
         {
             if (cuadros.Count != 0)
             {
                 IEquipo cnf = cuadros.ElementAt(0);
                 cuadros.RemoveAt(0);
                 return cnf;
             }
             else
             {
                 Console.WriteLine("ERROR - no se han cargado los equipos ");
                 return null;
             }
         }

        
         public IList<IEquipo> CargarEquipos()
        {           
            ManejadorArchivos lector = new ManejadorArchivos();
            List<IEquipo> lista = new List<IEquipo>();
            ArrayList datos = lector.Leer(archivoDeLista);
            foreach (String linea in datos)
            {
                object[] celdas = linea.Split(',');
                Console.WriteLine(celdas.Length.ToString());
                String nombre = Convert.ToString(celdas[0]);

                IEquipo cuadro = new Equipo(nombre);
                lista.Add(cuadro);
                Console.WriteLine("Se creó el equipo :"+nombre);


            }
            return lista;            
        }
    }
}
