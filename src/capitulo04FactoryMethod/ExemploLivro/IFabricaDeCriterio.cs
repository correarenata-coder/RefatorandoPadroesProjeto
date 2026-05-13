using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro
{
    public interface IFabricaDeCriterio
    {
        CriterioDeBusca CriarCriterio();
    }
}
