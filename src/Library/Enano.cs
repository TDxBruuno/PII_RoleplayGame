using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Enano
    {
        public string Nombre{get; }
        public int ValorAtaque{get; set;}
        public int ValorDefensa{get; set;}
        public int Vida{get; set;}
        public string Tipo{get; }
        public List<Elemento> Items {get; }
       
        public Enano(string nombre, int vida, string tipo, int valorAtaque, int valorDefensa)
        {
            Nombre=nombre;
            Vida=vida;
            Tipo=tipo;
            ValorAtaque=valorAtaque;
            ValorDefensa=valorDefensa;
            Items= new List<Elemento>();
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

        public void Atacar( Enano objetivo)
        {
            int ataqueTotal = calcularAtaque();
            objetivo.Vida -= ataqueTotal;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {ataqueTotal} puntos de daño.");
            Console.WriteLine($"vida objetivo: {objetivo.Vida}");
        }

        public void Atacar(Elfo objetivo)
        {
            int ataqueTotal = calcularAtaque();
            objetivo.Vida -= ataqueTotal;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {ataqueTotal} puntos de daño.");
            Console.WriteLine($"vida objetivo: {objetivo.Vida}");
        }

        public void Atacar(Mago objetivo)
        {
            int ataqueTotal = calcularAtaque();
            objetivo.Vida -= ataqueTotal;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {ataqueTotal} puntos de daño.");
            Console.WriteLine($"vida objetivo: {objetivo.Vida}");
        }

        public void Defensa()
        {
            int defensaTotal = calcularDefensa();
            Vida += defensaTotal;
            Console.WriteLine($"{Nombre} se defiende y gana {defensaTotal} puntos de resistencia.");
        }
    }

}