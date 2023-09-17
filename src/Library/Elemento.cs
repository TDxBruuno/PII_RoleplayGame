using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Elemento
    {
        public string Nombre{get; }
        public string Tipo{get; }
        public int ValorAttack{get; set; }
        public int ValorDefend{get; set; }
        public bool PropiedadesMagicas{get; set; }
        public Elemento(string nombre, string tipo, int valorAttack=0, int valorDefend=0)
        {
            Nombre=nombre;
            Tipo=tipo;
            ValorAttack=valorAttack;
            ValorDefend=valorDefend;
            PropiedadesMagicas=false;
        }
        public void Usar()
        {
            Console.WriteLine($"El elemento {Nombre} ha sido usado");
        }
        public void Encantar()
        {
            if (PropiedadesMagicas)
            {
                Console.WriteLine($"{Nombre} ya está encantado");
            }
            else
            {
                PropiedadesMagicas=true;
                Console.WriteLine($"{Nombre} ha sido encantado y ahora tiene propiedades mágicas.");
            }
        }
        public void Mejorar(int aumentoPoder)
        {
            ValorAttack+=aumentoPoder;
            ValorDefend+=aumentoPoder;
            Console.WriteLine($"{Nombre} ha sido mejorado y su poder aumenta en {aumentoPoder} puntos.");
        }
    }
}