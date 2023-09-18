using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace RolePlay
{
    public class Arma : Elemento
    {
        public Arma(string nombre, int valorAttack) : base(nombre, "Arma", valorAttack, 15)
        {
            
        }
    }

}