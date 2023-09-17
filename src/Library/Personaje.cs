using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Personaje
    {
        public string Nombre{get; }
        public int Nivel{get; set;}
        public int Magia{get; set;}
        public int Vida{get; set;}
        public string Tipo{get; }
        public List<Elemento> Items {get; }
        
        public Personaje(string nombre, int nivel, int magia, int vida, string tipo)
        {
            Nombre=nombre;
            Nivel=nivel;
            Magia=magia;
            Vida=vida;
            Tipo=tipo;
            Items= new List<Elemento>();
        }
        public void Attack(Personaje objetivo)
        {
            int daño=Nivel*5; 
            objetivo.Vida-=daño;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} y le causa {daño} puntos de daño.");
        }
        public void Defend()
        {
            int resistenciaExtra=Nivel*2; 
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
        public void Item(Elemento item)
        {
             if (Items.Contains(item))
            {
                if (item.Tipo == "Arma")
                {
                    int aumentoAttack = item.ValorAttack;
                    Nivel+=aumentoAttack;
                    Console.WriteLine($"{Nombre} usa un {item.Nombre} y aumenta su ataque en {aumentoAttack} puntos.");
                }
                else if (item.Tipo=="Armadura")
                {
                    int aumentoDefend = item.ValorDefend;
                    Vida+=aumentoDefend;
                    Console.WriteLine($"{Nombre} usa una {item.Nombre} y aumenta su vida en {aumentoDefend} puntos.");
                }
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene ese elemento en su inventario.");
            }
        }
    }
}