using System;
using System.Collections;
using System.IO;

namespace ObligatorioPoo2015
{
    public class ManejadorArchivos
    {
        public void Escribir(string nomArchivo, string texto)
        {
            StreamWriter writer = new StreamWriter(nomArchivo, true);
            writer.WriteLine(texto);
            writer.Close();
        }

        /* Lector de archivos, se le agrega try - catch */
        public ArrayList Leer(string nomArchivo)
        {
            try
            {
                StreamReader reader = new StreamReader(nomArchivo);
                ArrayList salida = new ArrayList();
                while (reader.Peek() > -1)
                {
                    salida.Add(reader.ReadLine());
                }
                reader.Close();
                return salida;
            }
            catch (Exception)
            {
                Console.Write("El archivo: [" + nomArchivo + " ] no existe");
                return null;
            }
        }      
        
    }
}
