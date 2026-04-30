using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo03._3_Polimorfismo
{
    public class Cartao : IPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("Pagamento com cartão");
        }
    }
}
