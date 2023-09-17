using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Mago: Personaje
    {
        public List<string> HabilidadesMagicas{get; }
        public LibroDeHechizos LibroDeHechizos{get; }

        public Mago(string nombre, int nivel, int vida, int magia):base(nombre, nivel, vida, magia , "Wizard")
        {
            HabilidadesMagicas=new List<string>();
             LibroDeHechizos = new LibroDeHechizos("Libro de Hechizos de " + nombre);
        }
        public void AprenderHechizo(string hechizo)
        {
            LibroDeHechizos.AgregarHechizo(hechizo);
            Console.WriteLine($"Se ha agregado el hechizo {hechizo} al libro de hechizos");
        }
        public void EstudiarHechizo(string nombreHechizo, int poderHechizo)
        {
            Hechizo nuevoHechizo=new Hechizo(nombreHechizo, poderHechizo);
            LibroDeHechizos.AgregarHechizo(nuevoHechizo);
            Console.WriteLine($"{Nombre} ha estudiado el hechizo '{nombreHechizo}' y lo ha añadido a su libro de hechizos");
        }
    }

}