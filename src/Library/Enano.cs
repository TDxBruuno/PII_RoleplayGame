using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Enano: Personaje
    {
        public Enano(string nombre, int nivel, int vida, int magia):base(nombre, nivel, vida, magia , "Enano")
        {
            // Habilidades especiales
        }
    }

}