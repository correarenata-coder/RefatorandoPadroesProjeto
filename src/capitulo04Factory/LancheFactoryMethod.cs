using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04Factory
{
    public abstract class LancheFactoryMethod
    {
        public abstract Lanche CriarLanche(int tipo);
    }
}
