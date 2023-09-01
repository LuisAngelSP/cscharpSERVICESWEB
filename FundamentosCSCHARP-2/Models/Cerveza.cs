using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo de alcohol debe ser de 5 %");
        }


        public Cerveza() : base(null, 0)
        {

        }


        public Cerveza(int cantidad, string Nombre ) : base(cantidad, Nombre)
        {

        }
    }
}
