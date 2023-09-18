using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class LibroDeHechizos
{
    private List<Hechizo> Hechizos { get; set; }

    public string Nombre { get; set; }

    public LibroDeHechizos(string nombre)
    {
        Nombre = nombre;
        Hechizos = new List<Hechizo>();
    }

    // Método para agregar un hechizo basado en una cadena de texto
    public void AgregarHechizo(string hechizoNombre)
    {
        Hechizo nuevoHechizo = new Hechizo(hechizoNombre, 0); // Asumiendo que el poder del hechizo es 0 por defecto
        Hechizos.Add(nuevoHechizo);
    }

    // Método para agregar un hechizo basado en un objeto Hechizo
    public void AgregarHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo);
    }
}

}