using System;
namespace ObligatorioPoo2015
{
public class Arbitro:IPersona
{
    private string nombre;
     private string apellido;

    public string Nombre
{
  get { return nombre; }
}

    public string Apellido
    {
        get { return apellido; }
    }
   

    public Arbitro (string name, string apell )
	{
        nombre = name;
        apellido = apell;
	}
}
}