using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class LibroDeHechizos : Elemento 
{
    private List<Hechizo> Hechizos { get; set; }
    


    public LibroDeHechizos(string nombre, string tipo):base(nombre,tipo,0,0)
    {
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