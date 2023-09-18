using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Elemento
    {
        public string Nombre{get; }
        public string Tipo{get; }
        public int ValorAtaque{get; set; }
        public int ValorDefensa{get; set; }
    
        public Elemento(string nombre, string tipo, int valorAttack, int valorDefend)
        {
            Nombre=nombre;
            Tipo=tipo;
            ValorAtaque=valorAttack;
            ValorDefensa=valorDefend;
        }
        
    }
}