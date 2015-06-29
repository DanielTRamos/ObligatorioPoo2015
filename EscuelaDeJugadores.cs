using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ObligatorioPoo2015
{
    class EscuelaDeJugadores
    {
        public void CrearArquero ()
        {
         ManejadorArchivos lector = new ManejadorArchivos();

        ArrayList datos = lector.Leer("C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/Arqueros.txt");
        ArrayList nuevosDatos = new ArrayList();
            foreach (String linea in datos)
            {
                
                object[] celdas = linea.Split(',');
                Console.WriteLine(celdas[3].ToString());
                if (celdas[3] == " ")
                {
                    Console.WriteLine(celdas.Length.ToString());
                    String nombre = Convert.ToString(celdas[0]);
                    String apellido = Convert.ToString(celdas[1]);
                    Int32 edad = Convert.ToInt32(celdas[2]);

                    Console.WriteLine(linea);

                    //String nuevaLinea = nombre + " , " + apellido + " , " + edad + " , " + "1";


                    String nuevaLinea = linea.Replace("0", "1");
                    Console.WriteLine(nuevaLinea);

                    nuevosDatos.Add(nuevaLinea);
                    //lector.Escribir("C:/Users/Luis Emilio/Documents/GitHub/ObligatorioPoo2015/Arqueros.txt", nuevaLinea);

                    // (string name, string apel, int age, string posicion,  int patear, int cabecear, int atajar, int regatear, int tirarTiroLibre)

                    Console.WriteLine(nombre, " , ", apellido);
                }
                else
                {
                    Console.WriteLine("ya esta");
                }
                
                
                //IJugador jugador = new Arquero(nombre, apellido, edad);
                
            }
            
        }
    }
}
