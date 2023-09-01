using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo de alcohol debe ser de 5 %");
        }

        public Vino(int Cantidad, string Nombre="pisco" ) : base(Nombre, Cantidad)
        {

        }


    }
}
