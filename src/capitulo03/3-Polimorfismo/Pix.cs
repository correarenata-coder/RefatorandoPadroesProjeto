using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo03._3_Polimorfismo
{
    public class Pix : IPagamento
    {
            
       public void Pagar()
        {
            Console.WriteLine("Pagamento com Pix");
        }
    }
}
