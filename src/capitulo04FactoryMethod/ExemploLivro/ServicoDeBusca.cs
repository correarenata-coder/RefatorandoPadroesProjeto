using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro
{
    public class ServicoDeBusca
    {
        public CriterioDeBusca? ultimoCriterio { get; private set; }

        public List<string> RealizarBuscaCom(CriterioDeBusca criterio)
        {
            ultimoCriterio = criterio;

            return new List<string>
        {
            "produto-1",
            "produto-2",
            "produto-3"
        };
        }
    }
}
