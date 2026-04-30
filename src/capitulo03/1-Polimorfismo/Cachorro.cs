using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo03._1_Polimorfismo
{
    public class Cachorro :Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("O cachorro late: Au Au!");
        }
    }
}
