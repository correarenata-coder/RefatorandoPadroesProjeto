using capitulo10_Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo10_Decorator
{
    public class Pizza : IPizza
    {
        public string Opcionais()
        {
            var pizza = "Pizza padrão ou normal";

            return pizza;
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}
