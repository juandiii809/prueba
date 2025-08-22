// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Hello, World!");

Personas persona = new Personas();
var persona1 = new Personas();
Estudiantes persona2 = new Estudiantes();

persona.id = 1;
persona.nombre = "carlos";
persona.estatura = 1.75m;
persona.vivo = false;
persona.fecha = DateTime.Now;
persona.Estado = new Estados() { id = 1, nombre = "viudo" };
persona.videojuegos = new List<Videojuegos>();
//persona.videojuegos.Add(new)


public class Estados
{
    public int? id;
    public string? nombre;
}

public class Videojuegos : Personas
{
    public int id;
    public string? nombre;
}
public class Personas
{
    public int? id;
    public string? nombre;
    public decimal estatura;
    public bool vivo;
    public DateTime fecha;
    public Estados? Estado;
    public List<Videojuegos>? videojuegos;
}

public class Estudiantes : Personas
{
    public int? carnet;
}
