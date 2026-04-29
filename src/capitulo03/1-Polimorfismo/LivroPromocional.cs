using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo03._1_Polimorfismo
{
    public class LivroPromocional : Livro
    {
        public override decimal CalcularPrecoFinal()
        {
            return  80m;
        }
    }
}
