using capitulo04_FactoryMethod.ExemploLivro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Criterios
{
    public class CriadorDeBuscaNormal : ICriadorDeCriterio
    {
        public CriterioDeBusca Criar(ParametrosDeBusca parametros)
        {
            return new CriterioDeBusca(
                parametros.ResultadosPorPagina,
                parametros.Categoria,
                parametros.OrdernarPor,
                parametros.Engine
            );
        }
    }
}
