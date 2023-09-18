using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Enano: Personaje
    {
        public Enano(string nombre, int vida, int magia):base(nombre, vida, magia , "Enano", 25, 15)
        {
            // Habilidades especiales
        }
    }

}