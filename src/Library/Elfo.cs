using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Elfo: Personaje
    {
        public Elfo(string nombre, int vida, int magia):base(nombre, vida, magia , "Elfo")
        {
            // caracteristicas especiales
        }
        
        public void Curar(Personaje objetivo)
        {
            objetivo.Vida = 100;
        }
    }

}