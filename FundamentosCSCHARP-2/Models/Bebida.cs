using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    class Bebida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }


        public Bebida(string Nombre, int Cantidad) {

            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public Bebida(int cantidad, string nombre)
        {
            Cantidad = cantidad;
            Nombre = nombre;
        }

        public void Beberse(int cuantoBebio)
        {
            this.Cantidad -= cuantoBebio;
        }
    }
}
