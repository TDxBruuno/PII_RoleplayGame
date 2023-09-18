using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Mago
    {

        public string Nombre{get; }
        public int ValorAtaque{get; set;}
        public int ValorDefensa{get; set;}
        public int Magia{get; set;}
        public int Vida{get; set;}
        public string Tipo{get; }
        public List<Elemento> Items {get; }
       
        public Mago(string nombre, int magia, int vida, string tipo, int valorAtaque, int valorDefensa)
        {
            Nombre=nombre;
            Magia=magia;
            Vida=vida;
            Tipo=tipo;
            ValorAtaque=valorAtaque;
            ValorDefensa=valorDefensa;
            Items= new List<Elemento>();
        }

        public void Hechizo(Elfo objetivo )
        {
            if (Tipo== "Mago")
            {
                int poderHechizo = Magia * 3; 
                Magia-=20; 
                objetivo.Vida-=poderHechizo;
                Console.WriteLine($"{Nombre} lanza un hechizo a {objetivo.Nombre} y causa {poderHechizo} puntos de daño.");
            }
        }

        public void Hechizo(Mago objetivo )
        {
            if (Tipo== "Mago")
            {
                int poderHechizo = Magia * 3; 
                Magia-=20; 
                objetivo.Vida-=poderHechizo;
                Console.WriteLine($"{Nombre} lanza un hechizo a {objetivo.Nombre} y causa {poderHechizo} puntos de daño.");
            }
        }
       
        public int calcularAtaque()
        {
            int valorAtaqueTotal = ValorAtaque;

            foreach (Elemento item in Items)
            {
                if (item.Tipo == "Arma")
                {
                    valorAtaqueTotal += item.ValorAtaque;
                }
            }

            return valorAtaqueTotal;
        }

        public int calcularDefensa()
        {
            int valorDefensaTotal = ValorDefensa;

            foreach (Elemento item in Items)
            {
                if (item.Tipo == "Armadura")
                {
                    valorDefensaTotal += item.ValorDefensa;
                }
            }

            return valorDefensaTotal;
        }

        public void Atacar(Enano objetivo)
        {
            int ataqueTotal = calcularAtaque();
            objetivo.Vida -= ataqueTotal;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {ataqueTotal} puntos de daño.");
        }

        public void Atacar(Elfo objetivo)
        {
            int ataqueTotal = calcularAtaque();
            objetivo.Vida -= ataqueTotal;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {ataqueTotal} puntos de daño.");
        }

        public void Atacar(Mago objetivo)
        {
            int ataqueTotal = calcularAtaque();
            objetivo.Vida -= ataqueTotal;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {ataqueTotal} puntos de daño.");
        }

        public void Defensa()
        {
            int defensaTotal = calcularDefensa();
            Vida += defensaTotal;
            Console.WriteLine($"{Nombre} se defiende y gana {defensaTotal} puntos de resistencia.");
        }

        public List<string> HabilidadesMagicas{get; }
        public LibroDeHechizos LibroDeHechizos{get; }

        public Mago(string nombre, int vida, int magia)
        {
            HabilidadesMagicas=new List<string>();
            LibroDeHechizos = new LibroDeHechizos("Libro de Hechizos de " + nombre);
        }
    
        public void EstudiarHechizo(string nombreHechizo, int poderHechizo)
        {
            Hechizo nuevoHechizo=new Hechizo(nombreHechizo, poderHechizo);
            LibroDeHechizos.AgregarHechizo(nuevoHechizo);
        }
    }

}