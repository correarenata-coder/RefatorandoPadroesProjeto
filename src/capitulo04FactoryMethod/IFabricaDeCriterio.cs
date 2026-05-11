using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod
{
    public interface IFabricaDeCriterio
    {
        CriterioDeBusca CriarCriterio();
    }
}
