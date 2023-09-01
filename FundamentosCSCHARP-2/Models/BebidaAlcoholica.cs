using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    internal interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }



        public void MaxRecomendado();
    }
}
