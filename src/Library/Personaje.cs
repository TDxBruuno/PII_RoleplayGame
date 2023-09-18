using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using RolePlay;
namespace RolePlay
{
    public class Personaje
    {
        public string Nombre{get; }
        public int AtaqueTotal{get; set;}
        public int DefensaTotal{get; set;}
        public int Magia{get; set;}
        public int Vida{get; set;}
        public string Tipo{get; }
        public List<Elemento> Items {get; }
        
        public Personaje(string nombre, int magia, int vida, string tipo)
        {
            Nombre=nombre;
            Magia=magia;
            Vida=vida;
            Tipo=tipo;
            Items= new List<Elemento>();
        }
        public void Ataque(Personaje objetivo)
        {
            int daño=AtaqueTotal*5; 
            objetivo.Vida-=daño;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {daño} puntos de daño.");
        }
        public void Defensa()
        {
            int resistenciaExtra=AtaqueTotal*2; 
            Magia-=10; 
            Console.WriteLine($"{Nombre} se defiende y gana {resistenciaExtra} puntos de resistencia.");
        }
        public void Hechizo(Personaje objetivo )
        {
            if (Tipo== "Wizard")
            {
                int poderHechizo = Magia * 3; 
                Magia-=20; 
                objetivo.Vida-=poderHechizo;
                Console.WriteLine($"{Nombre} lanza un hechizo a {objetivo.Nombre} y causa {poderHechizo} puntos de daño.");
            }
        }
       
       
       
        public void calcularAtaque(Elemento item)
        {
            if (item.ValorAtaque != 0)
            {
                int aumentoAtaque = item.ValorAtaque;
                AtaqueTotal += aumentoAtaque;
                Console.WriteLine($"El ataque total del personaje es de {AtaqueTotal}");
            }
        }

        public void calcularDefensa(Elemento item)
        {
            if (item.ValorDefensa != 0)
            {
                int defensaTotal = item.ValorDefensa;
                Vida+=defensaTotal;
                Console.WriteLine($"La defensa total del personaje es de {DefensaTotal}");
            }
        }

        
    }
    
}