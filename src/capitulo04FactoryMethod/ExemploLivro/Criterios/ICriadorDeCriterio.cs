using capitulo04_FactoryMethod.ExemploLivro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Criterios
{
    public interface ICriadorDeCriterio
    {
        CriterioDeBusca Criar(ParametrosDeBusca parametros);
    }
}
