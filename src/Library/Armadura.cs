using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Armadura :Elemento
    {
        public Armadura(string nombre, int valorDefend) : base(nombre, "Armadura", valorDefend)
        {}
    }

}