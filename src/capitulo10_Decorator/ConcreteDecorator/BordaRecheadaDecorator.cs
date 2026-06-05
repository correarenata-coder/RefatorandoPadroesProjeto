using capitulo10_Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo10_Decorator.ConcreteDecorator
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\n com borda recheada";
            return pizza;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 3.00M;
            return preco;
        }
    }
}
