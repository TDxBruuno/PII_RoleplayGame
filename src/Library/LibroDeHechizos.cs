using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class LibroDeHechizos : Elemento
{
    private List<Hechizo> Hechizos { get; set; }

    public string Nombre { get; set; }

    public LibroDeHechizos()
    {
        Nombre = nombre;
        Hechizos = new List<Hechizo>();
    }

    // Método para agregar un hechizo basado en una cadena de texto
    public void AgregarTextHechizo(string hechizoNombre)
    {
        Hechizo nuevoHechizo = new Hechizo(hechizoNombre, 0); // Asumiendo que el poder del hechizo es 0 por defecto
        Hechizos.Add(nuevoHechizo);
    }

    // Método para agregar un hechizo basado en un objeto Hechizo
    public void AgregarObjHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo);
    }
}

}