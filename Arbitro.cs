using System;
namespace ObligatorioPoo2015
{
public class Arbitro:IArbitro
{
    private string nombre;
     private string apellido;
     private int edad;
     private string posicion;
     private int arbitrar;

    public string Nombre
{
        get { return nombre; }
    set { nombre = value; }

}

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
   

    public Arbitro (string name, string apell )
	{
        nombre = name;
        apellido = apell;
	}

    public int Edad
    {
        get
        {
            return edad;
        }
        set
        {
            edad = value;
        }
    }

    public string Posicion
    {
        get
        {
            return posicion;
        }
        set
        {
            posicion = value;
        }
    }

    public int Arbitrar
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    /**
     * Constructor:
     * @author: Luis TITO
     * @param: String nombre, int edad, String apellido, String posicion, int arbitrar
     */
     
    public Arbitro(String nombre, int edad, String apellido, String posicion, int arbitrar)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.apellido = apellido;
        this.posicion = posicion;
        this.arbitrar = arbitrar;
    }

     
}
}