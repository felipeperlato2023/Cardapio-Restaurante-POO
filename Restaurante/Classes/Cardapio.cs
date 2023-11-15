using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Classes
{
    internal class Cardapio
    {
        public string Pratos { get; set; }

        public string Bebidas { get; set; }

        public Cardapio(string pratos)
        {
            Pratos = pratos;
        }

        public Cardapio(string pratos, string bebidas)
        {
            Pratos = pratos;
            Bebidas = bebidas;
        }
    }


}
