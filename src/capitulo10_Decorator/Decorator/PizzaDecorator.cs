using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo10_Decorator.Decorator
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string Opcionais()
        {
            var pizza = _pizza.Opcionais();
            return pizza;
        }

        public virtual decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }
    }
}
